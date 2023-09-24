using KmnlkUMSDll.Managment;
using KmnlkUMSEngine.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static KmnlkCommon.Shareds.LoggerManagement;
using KmnlkUMSEngine.Constants;
namespace KmnlkUMSApi.Management
{
    public class ContextManagement
    {


        public ILog logger;
        public ConnectionManager connectionManager;

        public ContextManagement(ConnectionManager connectionManager, ILog logger)
        {
            this.connectionManager = connectionManager;
            this.logger = logger;
        }



        private DelegationManagement delegationBussinesManagement;
        public DelegationManagement instanceDelegationBussinesManagement()
        {
            if (delegationBussinesManagement == null)
            {
                delegationBussinesManagement = new DelegationManagement(connectionManager, logger);

            }
            return delegationBussinesManagement;
        }
        private DepartmentContactManagement departmentContactBussinesManagement;
        public DepartmentContactManagement instanceDepartmentContactBussinesManagement()
        {
            if (departmentContactBussinesManagement == null)
            {
                departmentContactBussinesManagement = new DepartmentContactManagement(connectionManager, logger);

            }
            return departmentContactBussinesManagement;
        }
        private DepartmentPositionAttachmentManagement departmentPositionAttachmentBussinesManagement;
        public DepartmentPositionAttachmentManagement instanceDepartmentPositionAttachmentBussinesManagement()
        {
            if (departmentPositionAttachmentBussinesManagement == null)
            {
                departmentPositionAttachmentBussinesManagement = new DepartmentPositionAttachmentManagement(connectionManager, logger);

            }
            return departmentPositionAttachmentBussinesManagement;
        }
        private DepartmentPositionManagement departmentPositionBussinesManagement;
        public DepartmentPositionManagement instanceDepartmentPositionBussinesManagement()
        {
            if (departmentPositionBussinesManagement == null)
            {
                departmentPositionBussinesManagement = new DepartmentPositionManagement(connectionManager, logger);

            }
            return departmentPositionBussinesManagement;
        }
        private DepartmentPositionNoteManagement departmentPositionNoteBussinesManagement;
        public DepartmentPositionNoteManagement instanceDepartmentPositionNoteBussinesManagement()
        {
            if (departmentPositionNoteBussinesManagement == null)
            {
                departmentPositionNoteBussinesManagement = new DepartmentPositionNoteManagement(connectionManager, logger);

            }
            return departmentPositionNoteBussinesManagement;
        }
        private DepartmentPrivilageManagement departmentPrivilageBussinesManagement;
        public DepartmentPrivilageManagement instanceDepartmentPrivilageBussinesManagement()
        {
            if (departmentPrivilageBussinesManagement == null)
            {
                departmentPrivilageBussinesManagement = new DepartmentPrivilageManagement(connectionManager, logger);

            }
            return departmentPrivilageBussinesManagement;
        }
        private DepartmentResponsipilityManagement departmentResponsipilityBussinesManagement;
        public DepartmentResponsipilityManagement instanceDepartmentResponsipilityBussinesManagement()
        {
            if (departmentResponsipilityBussinesManagement == null)
            {
                departmentResponsipilityBussinesManagement = new DepartmentResponsipilityManagement(connectionManager, logger);

            }
            return departmentResponsipilityBussinesManagement;
        }
        private OperationManagement operationBussinesManagement;
        public OperationManagement instanceOperationBussinesManagement()
        {
            if (operationBussinesManagement == null)
            {
                operationBussinesManagement = new OperationManagement(connectionManager, logger);

            }
            return operationBussinesManagement;
        }
        private PositionContactManagement positionContactBussinesManagement;
        public PositionContactManagement instancePositionContactBussinesManagement()
        {
            if (positionContactBussinesManagement == null)
            {
                positionContactBussinesManagement = new PositionContactManagement(connectionManager, logger);

            }
            return positionContactBussinesManagement;
        }
        private PositionManagement positionBussinesManagement;
        public PositionManagement instancePositionBussinesManagement()
        {
            if (positionBussinesManagement == null)
            {
                positionBussinesManagement = new PositionManagement(connectionManager, logger);

            }
            return positionBussinesManagement;
        }
        private ProfileFieldManagement profileFieldBussinesManagement;
        public ProfileFieldManagement instanceProfileFieldBussinesManagement()
        {
            if (profileFieldBussinesManagement == null)
            {
                profileFieldBussinesManagement = new ProfileFieldManagement(connectionManager, logger);

            }
            return profileFieldBussinesManagement;
        }
        private ProfileManagement profileBussinesManagement;
        public ProfileManagement instanceProfileBussinesManagement()
        {
            if (profileBussinesManagement == null)
            {
                profileBussinesManagement = new ProfileManagement(connectionManager, logger);

            }
            return profileBussinesManagement;
        }
        private RoleContactManagement roleContactBussinesManagement;
        public RoleContactManagement instanceRoleContactBussinesManagement()
        {
            if (roleContactBussinesManagement == null)
            {
                roleContactBussinesManagement = new RoleContactManagement(connectionManager, logger);

            }
            return roleContactBussinesManagement;
        }
        private RoleManagement roleBussinesManagement;
        public RoleManagement instanceRoleBussinesManagement()
        {
            if (roleBussinesManagement == null)
            {
                roleBussinesManagement = new RoleManagement(connectionManager, logger);

            }
            return roleBussinesManagement;
        }
        private RolePositionAttachmentManagement rolePositionAttachmentBussinesManagement;
        public RolePositionAttachmentManagement instanceRolePositionAttachmentBussinesManagement()
        {
            if (rolePositionAttachmentBussinesManagement == null)
            {
                rolePositionAttachmentBussinesManagement = new RolePositionAttachmentManagement(connectionManager, logger);

            }
            return rolePositionAttachmentBussinesManagement;
        }
        private RolePositionManagement rolePositionBussinesManagement;
        public RolePositionManagement instanceRolePositionBussinesManagement()
        {
            if (rolePositionBussinesManagement == null)
            {
                rolePositionBussinesManagement = new RolePositionManagement(connectionManager, logger);

            }
            return rolePositionBussinesManagement;
        }
        private RolePositionNoteManagement rolePositionNoteBussinesManagement;
        public RolePositionNoteManagement instanceRolePositionNoteBussinesManagement()
        {
            if (rolePositionNoteBussinesManagement == null)
            {
                rolePositionNoteBussinesManagement = new RolePositionNoteManagement(connectionManager, logger);

            }
            return rolePositionNoteBussinesManagement;
        }
        private RolePrivilageManagement rolePrivilageBussinesManagement;
        public RolePrivilageManagement instanceRolePrivilageBussinesManagement()
        {
            if (rolePrivilageBussinesManagement == null)
            {
                rolePrivilageBussinesManagement = new RolePrivilageManagement(connectionManager, logger);

            }
            return rolePrivilageBussinesManagement;
        }
        private RoleResponsipilityManagement roleResponsipilityBussinesManagement;
        public RoleResponsipilityManagement instanceRoleResponsipilityBussinesManagement()
        {
            if (roleResponsipilityBussinesManagement == null)
            {
                roleResponsipilityBussinesManagement = new RoleResponsipilityManagement(connectionManager, logger);

            }
            return roleResponsipilityBussinesManagement;
        }
        private SettingManagement settingBussinesManagement;
        public SettingManagement instanceSettingBussinesManagement()
        {
            if (settingBussinesManagement == null)
            {
                settingBussinesManagement = new SettingManagement(connectionManager, logger);

            }
            return settingBussinesManagement;
        }
        private UserAttachmentManagement userAttachmentBussinesManagement;
        public UserAttachmentManagement instanceUserAttachmentBussinesManagement()
        {
            if (userAttachmentBussinesManagement == null)
            {
                userAttachmentBussinesManagement = new UserAttachmentManagement(connectionManager, logger);

            }
            return userAttachmentBussinesManagement;
        }
        private UserContactManagement userContactBussinesManagement;
        public UserContactManagement instanceUserContactBussinesManagement()
        {
            if (userContactBussinesManagement == null)
            {
                userContactBussinesManagement = new UserContactManagement(connectionManager, logger);

            }
            return userContactBussinesManagement;
        }
        private UserMacManagement userMacBussinesManagement;
        public UserMacManagement instanceUserMacBussinesManagement()
        {
            if (userMacBussinesManagement == null)
            {
                userMacBussinesManagement = new UserMacManagement(connectionManager, logger);

            }
            return userMacBussinesManagement;
        }
        private UserManagment userBussinesManagement;
        public UserManagment instanceUserBussinesManagement()
        {
            if (userBussinesManagement == null)
            {
                userBussinesManagement = new UserManagment(connectionManager, logger);

            }
            return userBussinesManagement;
        }
        private UserNoteManagement userNoteBussinesManagement;
        public UserNoteManagement instanceUserNoteBussinesManagement()
        {
            if (userNoteBussinesManagement == null)
            {
                userNoteBussinesManagement = new UserNoteManagement(connectionManager, logger);

            }
            return userNoteBussinesManagement;
        }
        private UserPositionAttachmentManagement userPositionAttachmentBussinesManagement;
        public UserPositionAttachmentManagement instanceUserPositionAttachmentBussinesManagement()
        {
            if (userPositionAttachmentBussinesManagement == null)
            {
                userPositionAttachmentBussinesManagement = new UserPositionAttachmentManagement(connectionManager, logger);

            }
            return userPositionAttachmentBussinesManagement;
        }
        private UserPositionManagement userPositionBussinesManagement;
        public UserPositionManagement instanceUserPositionBussinesManagement()
        {
            if (userPositionBussinesManagement == null)
            {
                userPositionBussinesManagement = new UserPositionManagement(connectionManager, logger);

            }
            return userPositionBussinesManagement;
        }
        private UserPositionNoteManagement userPositionNoteBussinesManagement;
        public UserPositionNoteManagement instanceUserPositionNoteBussinesManagement()
        {
            if (userPositionNoteBussinesManagement == null)
            {
                userPositionNoteBussinesManagement = new UserPositionNoteManagement(connectionManager, logger);

            }
            return userPositionNoteBussinesManagement;
        }

     
     

    }
}