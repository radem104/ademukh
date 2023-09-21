define("NavAgreement2Page", [], function() {
	return {
		entitySchemaName: "NavAgreement",
		attributes: {
			"NavNameVirtual":{
				dataValueType: Terrasoft.DataValueType.String,	
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				dependencies: [
					{
						methodName: "changingNumber",
						columns: ["NavName"]
					}
				]			
			},		
		},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{
			"TabLabelCreditGroupcdf108a9": {
				"ea681f8d-f4c1-4c9a-b541-299d052d18cc": {
					"uId": "ea681f8d-f4c1-4c9a-b541-299d052d18cc",
					"enabled": true,
					"removed": true,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavName"
							}
						}
					]
				},
				"09f480c1-c582-414f-8a4c-0c3065297293": {
					"uId": "09f480c1-c582-414f-8a4c-0c3065297293",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavContact"
							}
						},
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavAuto"
							}
						}
					]
				}
			},
			"NavFactSumma": {
				"9d5811cf-1d6f-4b5e-9338-51f92b6e9203": {
					"uId": "9d5811cf-1d6f-4b5e-9338-51f92b6e9203",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 1,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavCredit"
							}
						}
					]
				}
			},
			"NavInitialFee": {
				"f85d828d-bdab-46b2-b66c-cf7671e82af5": {
					"uId": "f85d828d-bdab-46b2-b66c-cf7671e82af5",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 1,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavCredit"
							}
						}
					]
				}
			},
			"NavFullCreditAmount": {
				"69be6799-ef1d-439a-9585-bdc118892ea1": {
					"uId": "69be6799-ef1d-439a-9585-bdc118892ea1",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 1,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavCredit"
							}
						}
					]
				}
			},
			"NavCreditPeriod": {
				"0e41a8ac-9f17-42db-a1b5-9835c02498ca": {
					"uId": "0e41a8ac-9f17-42db-a1b5-9835c02498ca",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 1,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavCredit"
							}
						}
					]
				}
			},
			"NavCreditAmount": {
				"b7af12b0-94c6-46c4-b553-eb9104178b44": {
					"uId": "b7af12b0-94c6-46c4-b553-eb9104178b44",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 1,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavCredit"
							}
						}
					]
				}
			},
			"NavPaymentPlanDate": {
				"f7e0b185-9cb3-4f5a-a6d9-9ed4aba344ca": {
					"uId": "f7e0b185-9cb3-4f5a-a6d9-9ed4aba344ca",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 1,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "NavCredit"
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
                this.addColumnValidator("NavDate", function() {return this.checkingField("NavDate")});
				this.addColumnValidator("NavContact",function() {return this.checkingField("NavContact")});
				this.addColumnValidator("NavAuto", function() {return this.checkingField("NavAuto")});
            },
			globalValue: function(value){
				return result2 = value
			},
			changingNumber: function() {
				var strName = "";
                var name = this.get("NavName");
				var result1 = this.globalValue();
				if(!Ext.isEmpty(name)){
                
                strName = String(name);
				if(result1 != name){
				result1 = strName.replace(/[а-яА-Яa-zA-Z]/gi , '-');	
				}			                                        			
			}
				this.globalValue(result1);
				this.set("NavName", result1);	
				
	}},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "NavName6891c147-a89f-4301-932c-10f0dbff4273",
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
				"name": "NavDatea7091ffc-bbad-411d-b670-dc9285f71ce8",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavDate",
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "NavContact7b7e11bb-c9e6-4a06-bdaf-e8d84e52ecb7",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavContact"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "NavFact6648efb6-0446-4928-8096-4b31f6078364",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavFact",
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "NavSumma6e5f2990-86f1-4d67-b16a-36b7908e035d",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavSumma",
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "NavAutoc0dcbb72-aaa8-410a-a37a-d5b4ac074c08",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "NavAuto"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "TabLabelCredit",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.TabLabelCreditTabCaption"
					},
					"items": [],
					"order": 0
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TabLabelCreditGroupcdf108a9",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.TabLabelCreditGroupcdf108a9GroupCaption"
					},
					"itemType": 15,
					"markerValue": "added-group",
					"items": []
				},
				"parentName": "TabLabelCredit",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TabLabelCreditGridLayoutee034770",
				"values": {
					"itemType": 0,
					"items": []
				},
				"parentName": "TabLabelCreditGroupcdf108a9",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NavCredit7c9f0ae6-016a-437a-bad1-50d3e2ec4e1b",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "TabLabelCreditGridLayoutee034770"
					},
					"bindTo": "NavCredit"
				},
				"parentName": "TabLabelCreditGridLayoutee034770",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NavFactSummad16a83c7-521d-451b-bc8f-6f055dd8c45e",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "TabLabelCreditGridLayoutee034770"
					},
					"bindTo": "NavFactSumma",
					"enabled": false
				},
				"parentName": "TabLabelCreditGridLayoutee034770",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "NavInitialFee21bbca2d-fe37-4bfb-8f61-22fa15e6c3e0",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "TabLabelCreditGridLayoutee034770"
					},
					"bindTo": "NavInitialFee",
					"enabled": false
				},
				"parentName": "TabLabelCreditGridLayoutee034770",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "NavFullCreditAmount4aef4914-8dbf-49c2-a629-2e11eeaacff2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "TabLabelCreditGridLayoutee034770"
					},
					"bindTo": "NavFullCreditAmount",
					"enabled": false
				},
				"parentName": "TabLabelCreditGridLayoutee034770",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "NavCreditPeriod912208e9-7204-4eca-861d-5efcbb3f2434",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 4,
						"layoutName": "TabLabelCreditGridLayoutee034770"
					},
					"bindTo": "NavCreditPeriod",
					"enabled": false
				},
				"parentName": "TabLabelCreditGridLayoutee034770",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "NavCreditAmount6765e915-04b2-47be-9dd3-40d2ad5c7e78",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 5,
						"layoutName": "TabLabelCreditGridLayoutee034770"
					},
					"bindTo": "NavCreditAmount",
					"enabled": false
				},
				"parentName": "TabLabelCreditGridLayoutee034770",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "NavPaymentPlanDate8b1706de-0ee7-40b4-a9a0-bd415943f272",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 6,
						"layoutName": "TabLabelCreditGridLayoutee034770"
					},
					"bindTo": "NavPaymentPlanDate",
					"enabled": false
				},
				"parentName": "TabLabelCreditGridLayoutee034770",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 1
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
