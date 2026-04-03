using System;

namespace HealthClinicApp
{
    public interface IAdminOperations
    {
        void ManageSpecialtyLookup();
        void DatabaseBackupTrigger();
        void ViewSystemAuditLogs();
    }
}
