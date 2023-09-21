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
				"operation": "insert",
				"name": "NotesAndFilesTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.NotesAndFilesTabCaption"
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
				"name": "Files",
				"values": {
					"itemType": 2
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NotesControlGroup",
				"values": {
					"itemType": 15,
					"caption": {
						"bindTo": "Resources.Strings.NotesGroupCaption"
					},
					"items": []
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Notes",
				"values": {
					"bindTo": "NavNotes",
					"dataValueType": 1,
					"contentType": 4,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"imageLoaded": {
							"bindTo": "insertImagesToNotes"
						},
						"images": {
							"bindTo": "NotesImagesCollection"
						}
					}
				},
				"parentName": "NotesControlGroup",
				"propertyName": "items",
				"index": 0
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
