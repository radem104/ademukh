define("ContactPageV2", [], function() {
	return {
		entitySchemaName: "Contact",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "AccountName",
				"values": {
					"tip": {
						"content": {
							"bindTo": "Resources.Strings.AccountNameTip"
						}
					},
					"enabled": true
				}
			},
			{
				"operation": "merge",
				"name": "JobTitleProfile",
				"values": {
					"tip": {
						"content": {
							"bindTo": "Resources.Strings.JobTitleProfileTip"
						}
					},
					"enabled": true
				}
			},
			{
				"operation": "merge",
				"name": "AccountMobilePhone",
				"values": {
					"tip": {
						"content": {
							"bindTo": "Resources.Strings.AccountMobilePhoneTip"
						}
					},
					"enabled": true
				}
			},
			{
				"operation": "remove",
				"name": "AccountMobilePhone",
				"properties": [
					"contentType"
				]
			},
			{
				"operation": "merge",
				"name": "AccountPhone",
				"values": {
					"tip": {
						"content": {
							"bindTo": "Resources.Strings.AccountPhoneTip"
						}
					},
					"enabled": true
				}
			},
			{
				"operation": "remove",
				"name": "AccountPhone",
				"properties": [
					"contentType"
				]
			},
			{
				"operation": "merge",
				"name": "AccountEmail",
				"values": {
					"tip": {
						"content": {
							"bindTo": "Resources.Strings.AccountEmailTip"
						}
					},
					"enabled": true
				}
			},
			{
				"operation": "remove",
				"name": "AccountEmail",
				"properties": [
					"contentType"
				]
			},
			{
				"operation": "insert",
				"name": "DATETIME8ab5a73b-67f1-4233-a296-26e731f7e9eb",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 6,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavFirstAgreement",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "merge",
				"name": "Dear",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "move",
				"name": "Dear",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "merge",
				"name": "Age",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "merge",
				"name": "JobTabContainer",
				"values": {
					"order": 2
				}
			},
			{
				"operation": "merge",
				"name": "CommunicationChannelsTab",
				"values": {
					"order": 6
				}
			},
			{
				"operation": "merge",
				"name": "DoNotUseEmail",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "DoNotUseSms",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "DoNotUseSms",
				"parentName": "CommunicationChannelsContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "DoNotUseCall",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "DoNotUseMail",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "HistoryTab",
				"values": {
					"order": 7
				}
			},
			{
				"operation": "merge",
				"name": "NotesAndFilesTab",
				"values": {
					"order": 8
				}
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 9
				}
			},
			{
				"operation": "merge",
				"name": "TrackingEventsTab",
				"values": {
					"order": 5
				}
			},
			{
				"operation": "merge",
				"name": "WrongBrowserInfoDescription",
				"values": {
					"layout": {
						"colSpan": 20,
						"rowSpan": 5,
						"column": 3,
						"row": 7
					}
				}
			},
			{
				"operation": "move",
				"name": "Language",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"index": 5
			}
		]/**SCHEMA_DIFF*/
	};
});
