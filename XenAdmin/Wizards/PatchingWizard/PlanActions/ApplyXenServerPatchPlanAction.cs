﻿/* Copyright (c) Citrix Systems Inc. 
 * All rights reserved. 
 * 
 * Redistribution and use in source and binary forms, 
 * with or without modification, are permitted provided 
 * that the following conditions are met: 
 * 
 * *   Redistributions of source code must retain the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer. 
 * *   Redistributions in binary form must reproduce the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer in the documentation and/or other 
 *     materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System.Collections.Generic;
using XenAdmin.Core;
using XenAPI;


namespace XenAdmin.Wizards.PatchingWizard.PlanActions
{
    public class ApplyXenServerPatchPlanAction : PlanActionWithSession
    {
        private readonly XenRef<Host> host;
        private readonly XenServerPatch xenServerPatch;
        private readonly List<PoolPatchMapping> mappings;

        public ApplyXenServerPatchPlanAction(Host host, XenServerPatch xenServerPatch, List<PoolPatchMapping> mappings)
            : base(host.Connection, string.Format(Messages.UPDATES_WIZARD_APPLYING_UPDATE, xenServerPatch.Name, host.Name))
        {
            this.host = new XenRef<Host>(host);
            this.xenServerPatch = xenServerPatch;
            this.mappings = mappings;
        }

        protected override void RunWithSession(ref Session session)
        {

            var mapping = mappings.Find(m => m.XenServerPatch.Uuid == xenServerPatch.Uuid);
            if (mapping != null && mapping.Pool_patch != null)
            {
                var patchRef = mapping.Pool_patch;

                XenRef<Task> task = Pool_patch.async_apply(session, patchRef.opaque_ref, host.opaque_ref);
         
                PollTaskForResultAndDestroy(Connection, ref session, task);
            }
        }
    }
}