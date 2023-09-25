define("NavCredit1Page", [], function() {
	return {
		entitySchemaName: "NavCredit",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"Files": {
				"schemaName": "FileDetailV2",
				"entitySchemaName": "NavCreditFile",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "NavCredit"
				}
			},
			"NavSchemac2a238c3Detaila892370a": {
				"schemaName": "NavSchemac2a238c3Detail",
				"entitySchemaName": "NavCreditAuto",
				"filter": {
					"detailColumn": "NavCredit",
					"masterColumn": "Id"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{
			"Timeline": {
				"aa2aad49-5b0d-492c-9bfd-4f3f419e1565": {
					"uId": "aa2aad49-5b0d-492c-9bfd-4f3f419e1565",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 5,
							"leftExpression": {
								"type": 1,
								"attribute": "NavDateStart"
							},
							"rightExpression": {
								"type": 1,
								"attribute": "NavDateEnd"
							}
						},
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 1,
								"attribute": "NavDateStart"
							},
							"rightExpression": {
								"type": 1,
								"attribute": "NavDateEnd"
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
                   
                    invalidMessage = this.get("Resources.Strings.MessageField");
                }   
				return {                 
					invalidMessage: invalidMessage
				};
			},
            dueDateValidator: function() {
                
                var invalidMessage = "";
                var dateDiff = new Date(2015, 10, 10) - new Date(2014, 10, 10);    
                if ((this.get("NavDateEnd") - this.get("NavDateStart")) < dateDiff) {
                   
                    invalidMessage = this.get("Resources.Strings.CreatedOnLessDueDateMessage");
                }
                
                return {
                    
                    invalidMessage: invalidMessage
                };
            },
           
            setValidationConfig: function() {
              
                this.callParent(arguments);
              
                this.addColumnValidator("NavDateEnd", this.dueDateValidator);           
                this.addColumnValidator("NavDateStart", this.dueDateValidator);
				this.addColumnValidator("Name", function() {return this.checkingField("Name")});           
                this.addColumnValidator("NavDateEnd", function() {return this.checkingField("NavDateEnd")});
				this.addColumnValidator("NavDateStart",function() {return this.checkingField("NavDateStart")});
				this.addColumnValidator("NavRatePerMonth", function() {return this.checkingField("NavRatePerMonth")});
            }},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Name5be57169-9519-4e57-a240-75bc9abe1841",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "Name"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NavDateEndf35f1396-0d77-4701-bf09-3bcd03805741",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavDateEnd"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "NavDateStartcb348faf-03d0-48c8-9d5a-c0aedc4865a3",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavDateStart"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "INTEGER7eb911e4-5c6b-4556-9043-703bfc9d6885",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavRatePerMonth",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
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
				"name": "NavSchemac2a238c3Detaila892370a",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail"
				},
				"parentName": "ESNTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Tab1b28988bTabLabel",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.Tab1b28988bTabLabelTabCaption"
					},
					"items": [],
					"order": 1
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Tab1b28988bTabLabelGroup862345ea",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.Tab1b28988bTabLabelGroup862345eaGroupCaption"
					},
					"itemType": 15,
					"markerValue": "added-group",
					"items": []
				},
				"parentName": "Tab1b28988bTabLabel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Tab1b28988bTabLabelGridLayout93d76d06",
				"values": {
					"itemType": 0,
					"items": []
				},
				"parentName": "Tab1b28988bTabLabelGroup862345ea",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NavCreditPeriod79b56ee7-7caf-4d8f-ae3b-d835d23ad46f",
				"values": {
					"layout": {
						"colSpan": 5,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "Tab1b28988bTabLabelGridLayout93d76d06"
					},
					"bindTo": "NavCreditPeriod"
				},
				"parentName": "Tab1b28988bTabLabelGridLayout93d76d06",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_DIFF*/
	};
});
