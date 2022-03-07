﻿using NewLife;
using NewLife.Cube;
using NewLife.Cube.Extensions;
using NewLife.Cube.ViewModels;
using NewLife.Web;
using Stardust.Data;

namespace Stardust.Web.Areas.Registry.Controllers
{
    [Menu(58)]
    [RegistryArea]
    public class AppCommandController : EntityController<AppCommand>
    {
        static AppCommandController()
        {
            {
                var df = ListFields.GetField("TraceId") as ListField;
                df.DisplayName = "跟踪";
                df.Url = StarHelper.BuildUrl("{TraceId}");
                df.DataVisible = (e, f) => e is AppCommand entity && !entity.TraceId.IsNullOrEmpty();
            }
        }

        protected override IEnumerable<AppCommand> Search(Pager p)
        {
            var appId = p["appId"].ToInt(-1);
            var command = p["command"];

            var start = p["dtStart"].ToDateTime();
            var end = p["dtEnd"].ToDateTime();

            return AppCommand.Search(appId, command, start, end, p["Q"], p);
        }
    }
}