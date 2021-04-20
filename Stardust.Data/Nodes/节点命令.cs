using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Stardust.Data.Nodes
{
    /// <summary>节点命令</summary>
    [Serializable]
    [DataObject]
    [Description("节点命令")]
    [BindIndex("IX_NodeCommand_NodeID_Status", false, "NodeID,Status")]
    [BindIndex("IX_NodeCommand_NodeID_Command", false, "NodeID,Command")]
    [BindIndex("IX_NodeCommand_UpdateTime_NodeID_Command", false, "UpdateTime,NodeID,Command")]
    [BindTable("NodeCommand", Description = "节点命令", ConnName = "Node", DbType = DatabaseType.None)]
    public partial class NodeCommand
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public Int32 ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private Int32 _NodeID;
        /// <summary>节点</summary>
        [DisplayName("节点")]
        [Description("节点")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("NodeID", "节点", "")]
        public Int32 NodeID { get => _NodeID; set { if (OnPropertyChanging("NodeID", value)) { _NodeID = value; OnPropertyChanged("NodeID"); } } }

        private String _Command;
        /// <summary>命令</summary>
        [DisplayName("命令")]
        [Description("命令")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Command", "命令", "", Master = true)]
        public String Command { get => _Command; set { if (OnPropertyChanging("Command", value)) { _Command = value; OnPropertyChanged("Command"); } } }

        private String _Argument;
        /// <summary>参数</summary>
        [DisplayName("参数")]
        [Description("参数")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Argument", "参数", "")]
        public String Argument { get => _Argument; set { if (OnPropertyChanging("Argument", value)) { _Argument = value; OnPropertyChanged("Argument"); } } }

        private DateTime _Expire;
        /// <summary>过期时间。未指定时表示不限制</summary>
        [DisplayName("过期时间")]
        [Description("过期时间。未指定时表示不限制")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Expire", "过期时间。未指定时表示不限制", "")]
        public DateTime Expire { get => _Expire; set { if (OnPropertyChanging("Expire", value)) { _Expire = value; OnPropertyChanged("Expire"); } } }

        private CommandStatus _Status;
        /// <summary>状态。命令状态</summary>
        [DisplayName("状态")]
        [Description("状态。命令状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Status", "状态。命令状态", "")]
        public CommandStatus Status { get => _Status; set { if (OnPropertyChanging("Status", value)) { _Status = value; OnPropertyChanged("Status"); } } }

        private Int32 _Times;
        /// <summary>次数。一共执行多少次，超过10次后取消</summary>
        [DisplayName("次数")]
        [Description("次数。一共执行多少次，超过10次后取消")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Times", "次数。一共执行多少次，超过10次后取消", "")]
        public Int32 Times { get => _Times; set { if (OnPropertyChanging("Times", value)) { _Times = value; OnPropertyChanged("Times"); } } }

        private String _Result;
        /// <summary>结果</summary>
        [DisplayName("结果")]
        [Description("结果")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Result", "结果", "")]
        public String Result { get => _Result; set { if (OnPropertyChanging("Result", value)) { _Result = value; OnPropertyChanged("Result"); } } }

        private String _CreateUser;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateUser", "创建者", "")]
        public String CreateUser { get => _CreateUser; set { if (OnPropertyChanging("CreateUser", value)) { _CreateUser = value; OnPropertyChanged("CreateUser"); } } }

        private Int32 _CreateUserID;
        /// <summary>创建人</summary>
        [DisplayName("创建人")]
        [Description("创建人")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建人", "")]
        public Int32 CreateUserID { get => _CreateUserID; set { if (OnPropertyChanging("CreateUserID", value)) { _CreateUserID = value; OnPropertyChanged("CreateUserID"); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public String CreateIP { get => _CreateIP; set { if (OnPropertyChanging("CreateIP", value)) { _CreateIP = value; OnPropertyChanged("CreateIP"); } } }

        private Int32 _UpdateUserID;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新者", "")]
        public Int32 UpdateUserID { get => _UpdateUserID; set { if (OnPropertyChanging("UpdateUserID", value)) { _UpdateUserID = value; OnPropertyChanged("UpdateUserID"); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "")]
        public String UpdateIP { get => _UpdateIP; set { if (OnPropertyChanging("UpdateIP", value)) { _UpdateIP = value; OnPropertyChanged("UpdateIP"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "ID": return _ID;
                    case "NodeID": return _NodeID;
                    case "Command": return _Command;
                    case "Argument": return _Argument;
                    case "Expire": return _Expire;
                    case "Status": return _Status;
                    case "Times": return _Times;
                    case "Result": return _Result;
                    case "CreateUser": return _CreateUser;
                    case "CreateUserID": return _CreateUserID;
                    case "CreateTime": return _CreateTime;
                    case "CreateIP": return _CreateIP;
                    case "UpdateUserID": return _UpdateUserID;
                    case "UpdateTime": return _UpdateTime;
                    case "UpdateIP": return _UpdateIP;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID": _ID = value.ToInt(); break;
                    case "NodeID": _NodeID = value.ToInt(); break;
                    case "Command": _Command = Convert.ToString(value); break;
                    case "Argument": _Argument = Convert.ToString(value); break;
                    case "Expire": _Expire = value.ToDateTime(); break;
                    case "Status": _Status = (CommandStatus)value.ToInt(); break;
                    case "Times": _Times = value.ToInt(); break;
                    case "Result": _Result = Convert.ToString(value); break;
                    case "CreateUser": _CreateUser = Convert.ToString(value); break;
                    case "CreateUserID": _CreateUserID = value.ToInt(); break;
                    case "CreateTime": _CreateTime = value.ToDateTime(); break;
                    case "CreateIP": _CreateIP = Convert.ToString(value); break;
                    case "UpdateUserID": _UpdateUserID = value.ToInt(); break;
                    case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                    case "UpdateIP": _UpdateIP = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得节点命令字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>节点</summary>
            public static readonly Field NodeID = FindByName("NodeID");

            /// <summary>命令</summary>
            public static readonly Field Command = FindByName("Command");

            /// <summary>参数</summary>
            public static readonly Field Argument = FindByName("Argument");

            /// <summary>过期时间。未指定时表示不限制</summary>
            public static readonly Field Expire = FindByName("Expire");

            /// <summary>状态。命令状态</summary>
            public static readonly Field Status = FindByName("Status");

            /// <summary>次数。一共执行多少次，超过10次后取消</summary>
            public static readonly Field Times = FindByName("Times");

            /// <summary>结果</summary>
            public static readonly Field Result = FindByName("Result");

            /// <summary>创建者</summary>
            public static readonly Field CreateUser = FindByName("CreateUser");

            /// <summary>创建人</summary>
            public static readonly Field CreateUserID = FindByName("CreateUserID");

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName("CreateTime");

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName("CreateIP");

            /// <summary>更新者</summary>
            public static readonly Field UpdateUserID = FindByName("UpdateUserID");

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName("UpdateIP");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得节点命令字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>节点</summary>
            public const String NodeID = "NodeID";

            /// <summary>命令</summary>
            public const String Command = "Command";

            /// <summary>参数</summary>
            public const String Argument = "Argument";

            /// <summary>过期时间。未指定时表示不限制</summary>
            public const String Expire = "Expire";

            /// <summary>状态。命令状态</summary>
            public const String Status = "Status";

            /// <summary>次数。一共执行多少次，超过10次后取消</summary>
            public const String Times = "Times";

            /// <summary>结果</summary>
            public const String Result = "Result";

            /// <summary>创建者</summary>
            public const String CreateUser = "CreateUser";

            /// <summary>创建人</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>更新者</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";
        }
        #endregion
    }
}