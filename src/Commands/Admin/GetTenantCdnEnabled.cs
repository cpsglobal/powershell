﻿using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;

using PnP.PowerShell.Commands.Base;
using System.Management.Automation;

namespace PnP.PowerShell.Commands.Admin
{
    [Cmdlet(VerbsCommon.Get, "TenantCdnEnabled")]
    public class GetTenantCdnEnabled : PnPAdminCmdlet
    {
        [Parameter(Mandatory = true)]
        public SPOTenantCdnType CdnType;

        protected override void ExecuteCmdlet()
        {
            var result = Tenant.GetTenantCdnEnabled(CdnType);
            ClientContext.ExecuteQueryRetry();
            WriteObject(result);
        }
    }
}