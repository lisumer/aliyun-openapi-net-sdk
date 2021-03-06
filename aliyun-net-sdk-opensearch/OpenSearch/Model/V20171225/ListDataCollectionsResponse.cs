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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListDataCollectionsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<ListDataCollections_ResultItem> result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListDataCollections_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListDataCollections_ResultItem
		{

			private string id;

			private string name;

			private string type;

			private int? status;

			private string dataCollectionType;

			private string industryName;

			private int? created;

			private int? updated;

			private string sundialId;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string DataCollectionType
			{
				get
				{
					return dataCollectionType;
				}
				set	
				{
					dataCollectionType = value;
				}
			}

			public string IndustryName
			{
				get
				{
					return industryName;
				}
				set	
				{
					industryName = value;
				}
			}

			public int? Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public int? Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
				}
			}

			public string SundialId
			{
				get
				{
					return sundialId;
				}
				set	
				{
					sundialId = value;
				}
			}
		}
	}
}
