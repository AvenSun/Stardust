﻿using NewLife.Cube;
using NewLife.Cube.Extensions;
using NewLife.Cube.ViewModels;
using NewLife.Web;
using Stardust.Data.Deployment;
using XCode.Membership;

namespace Stardust.Web.Areas.Deployment.Controllers;

[Menu(70, false)]
[DeploymentArea]
public class AppDeployHistoryController : ReadOnlyEntityController<AppDeployHistory>
{
    static AppDeployHistoryController()
    {
        ListFields.RemoveField("Id");
        ListFields.AddDataField("Remark", null, "TraceId");
        ListFields.TraceUrl();

        {
            var df = ListFields.GetField("NodeName") as ListField;
            df.Url = "/Nodes/Node?Id={NodeID}";
            df.Target = "frame";
        }
    }

    protected override IEnumerable<AppDeployHistory> Search(Pager p)
    {
        var id = p["id"].ToInt(-1);
        if (id > 0)
        {
            var entity = AppDeployHistory.FindById(id);
            if (entity != null) return new List<AppDeployHistory> { entity };
        }

        var appId = p["appId"].ToInt(-1);
        var nodeId = p["nodeId"].ToInt(-1);

        var start = p["dtStart"].ToDateTime();
        var end = p["dtEnd"].ToDateTime();

        return AppDeployHistory.Search(appId, nodeId, null, start, end, p["Q"], p);
    }
}