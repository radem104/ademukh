define("NavAuto1Page", ["ext-base"], function(Ext) {
	return {
		entitySchemaName: "NavAuto",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"Files": {
				"schemaName": "FileDetailV2",
				"entitySchemaName": "NavAutoFile",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "NavAuto"
				}
			},
			"NavSchemaModel": {
				"schemaName": "NavSchema077dbdb7Detail",
				"entitySchemaName": "NavModel",
				"filter": {
					"detailColumn": "NavBrand",
					"masterColumn": "Id"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{
			"NavInAccident": {
				"80a6afe3-cc73-4a29-9b57-beb7152409b7": {
					"uId": "80a6afe3-cc73-4a29-9b57-beb7152409b7",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 1,
								"attribute": "NavUsed"
							},
							"rightExpression": {
								"type": 0,
								"value": true,
								"dataValueType": 12
							}
						}
					]
				}
			},
			"NavOwnersCount": {
				"a87e2388-b7dc-4316-824d-7d9111b6acaa": {
					"uId": "a87e2388-b7dc-4316-824d-7d9111b6acaa",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 1,
								"attribute": "NavUsed"
							},
							"rightExpression": {
								"type": 0,
								"value": true,
								"dataValueType": 12
							}
						}
					]
				}
			},
			"NavKm": {
				"c9b0e9ac-ba62-4494-852e-93b78c0becc8": {
					"uId": "c9b0e9ac-ba62-4494-852e-93b78c0becc8",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 1,
								"attribute": "NavUsed"
							},
							"rightExpression": {
								"type": 0,
								"value": true,
								"dataValueType": 12
							}
						}
					]
				}
			}
		}/**SCHEMA_BUSINESS_RULES*/,
		methods: {
			checkingField: function(name){
				var invalidMessage = "";
				var value = this.get(name);
				if (Ext.isEmpty(value)) {
                   
                    invalidMessage = this.get("Resources.Strings.CreatedOnLessDueDateMessage");
                }   
				return {                 
					invalidMessage: invalidMessage
				};
			},
           
            setValidationConfig: function() {
              
                this.callParent(arguments);
              
                this.addColumnValidator("NavName", function() {return this.checkingField("NavName")});           
                this.addColumnValidator("NavBrand", function() {return this.checkingField("NavBrand")});
				this.addColumnValidator("NavEngineCapacity",function() {return this.checkingField("NavEngineCapacity")});
				this.addColumnValidator("NavYearRelease", function() {return this.checkingField("NavYearRelease")});
				this.addColumnValidator("NavAmount", function() {return this.checkingField("NavAmount")});
            }
		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "NavName947dcfd5-813c-48bb-bd92-fcf6821d8fb0",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavName"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NavBrand32d67faf-fbc8-48cf-9430-feb81b891d1e",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavBrand"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "INTEGER0551c782-a488-4abb-bb68-ed13296cd956",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavEngineCapacity",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "INTEGER0deb4235-75fe-466b-96ab-98178f031b4e",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavYearRelease",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "NavAmount89559c10-5111-41b4-9bf8-1acd9bee3cea",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavAmount"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "NavUsedbbaa86a0-4208-485e-b748-7d5e969ddb78",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavUsed"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "NavInAccident56eee4f0-2680-4c12-ac2b-95cebb5cde20",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 6,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavInAccident"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "NavOwnersCount05b4aef2-c738-4640-93fb-a14fddc3fee1",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 7,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavOwnersCount"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "insert",
				"name": "NavKmbe858b87-57c3-4c1b-812e-64a019df7fbf",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 8,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavKm"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 8
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 0
				}
			},
			{
				"operation": "insert",
				"name": "NavSchemaModel",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail"
				},
				"parentName": "ESNTab",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_DIFF*/
	};
});
