/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceResponse.RequestId = _ctx.StringValue("GetInstance.RequestId");
			getInstanceResponse.Success = _ctx.BooleanValue("GetInstance.Success");
			getInstanceResponse.ErrorMessage = _ctx.StringValue("GetInstance.ErrorMessage");
			getInstanceResponse.ErrorCode = _ctx.StringValue("GetInstance.ErrorCode");

			GetInstanceResponse.GetInstance_Instance instance = new GetInstanceResponse.GetInstance_Instance();
			instance.InstanceId = _ctx.StringValue("GetInstance.Instance.InstanceId");
			instance.InstanceType = _ctx.StringValue("GetInstance.Instance.InstanceType");
			instance.EnvType = _ctx.StringValue("GetInstance.Instance.EnvType");
			instance.Host = _ctx.StringValue("GetInstance.Instance.Host");
			instance.Port = _ctx.IntegerValue("GetInstance.Instance.Port");
			instance.Sid = _ctx.StringValue("GetInstance.Instance.Sid");
			instance.InstanceAlias = _ctx.StringValue("GetInstance.Instance.InstanceAlias");
			instance.DataLinkName = _ctx.StringValue("GetInstance.Instance.DataLinkName");
			instance.DbaNickName = _ctx.StringValue("GetInstance.Instance.DbaNickName");
			instance.SafeRuleId = _ctx.StringValue("GetInstance.Instance.SafeRuleId");
			instance.QueryTimeout = _ctx.IntegerValue("GetInstance.Instance.QueryTimeout");
			instance.ExportTimeout = _ctx.IntegerValue("GetInstance.Instance.ExportTimeout");
			instance.State = _ctx.StringValue("GetInstance.Instance.State");
			instance.DbaId = _ctx.StringValue("GetInstance.Instance.DbaId");
			instance.DdlOnline = _ctx.IntegerValue("GetInstance.Instance.DdlOnline");
			instance.UseDsql = _ctx.IntegerValue("GetInstance.Instance.UseDsql");
			instance.EcsInstanceId = _ctx.StringValue("GetInstance.Instance.EcsInstanceId");
			instance.VpcId = _ctx.StringValue("GetInstance.Instance.VpcId");
			instance.EcsRegion = _ctx.StringValue("GetInstance.Instance.EcsRegion");
			instance.DatabaseUser = _ctx.StringValue("GetInstance.Instance.DatabaseUser");
			instance.DatabasePassword = _ctx.StringValue("GetInstance.Instance.DatabasePassword");
			instance.InstanceSource = _ctx.StringValue("GetInstance.Instance.InstanceSource");

			List<string> instance_ownerIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetInstance.Instance.OwnerIdList.Length"); i++) {
				instance_ownerIdList.Add(_ctx.StringValue("GetInstance.Instance.OwnerIdList["+ i +"]"));
			}
			instance.OwnerIdList = instance_ownerIdList;

			List<string> instance_ownerNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetInstance.Instance.OwnerNameList.Length"); i++) {
				instance_ownerNameList.Add(_ctx.StringValue("GetInstance.Instance.OwnerNameList["+ i +"]"));
			}
			instance.OwnerNameList = instance_ownerNameList;
			getInstanceResponse.Instance = instance;
        
			return getInstanceResponse;
        }
    }
}
