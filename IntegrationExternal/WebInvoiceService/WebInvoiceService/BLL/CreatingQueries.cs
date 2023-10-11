
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Terrasoft.Nui.ServiceModel.DataContract;

namespace WebInvoiceService.BLL
{
    public class CreatingQueries
    {
        public RequestClass request = new RequestClass();
        public void SelectAgreement(string numberAgreement, float sumNewInvoice) {

            var select = new SelectQuery()
            {
                RootSchemaName = "NavAgreement",
                Columns = new SelectQueryColumns()
                {
                    Items = new Dictionary<string, SelectQueryColumn>()
                    {
                        {
                            "NavName",
                            new SelectQueryColumn()
                            {
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "NavName",
                                }
                            }
                        },
                    },
                },
                Filters = new Filters()
                {
                    FilterType = FilterType.FilterGroup,
                    ComparisonType = Terrasoft.Core.Entities.FilterComparisonType.Equal,
                    LogicalOperation = Terrasoft.Common.LogicalOperationStrict.And,
                    Items = new Dictionary<string, Filter>()
                    {
                        {
                            "NavNameFilter",
                            new Filter()
                            {
                                ComparisonType = Terrasoft.Core.Entities.FilterComparisonType.Equal,
                                LogicalOperation = Terrasoft.Common.LogicalOperationStrict.And,
                                FilterType = FilterType.CompareFilter,
                                LeftExpression =  new BaseExpression()
                                {
                                    ColumnPath =  "NavName",
                                    ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.SchemaColumn,
                                },
                                RightExpression = new BaseExpression()
                                {
                                    ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.Parameter,
                                    Parameter = new Parameter()
                                    {
                                        Value = numberAgreement,
                                    }
                                }
                            }
                        }
                    }
                }
            };

            string json = JsonConvert.SerializeObject(select);
            
            string navName = "";
            string id = "";
            var resultRequerst = request.SelectRequest(json);
            var data = JObject.Parse(resultRequerst)["rows"].ToArray();
            foreach (var p in data)
            {
                navName = p["NavName"].ToString();
                id = p["Id"].ToString();
            }
            if (navName != null) CreateNewInvoice(id, numberAgreement, sumNewInvoice);
            else throw new Exception("Имя или номер договора не найдены");

        }

        public void CreateNewInvoice(string idAgreement, string numberAgreement, float sumNewInvoice)
        {
            var insert = new InsertQuery()
            {
                RootSchemaName = "NavInvoice",
                ColumnValues = new ColumnValues()
                {
                    Items = new Dictionary<string, ColumnExpression>()
                    {
                        {
                            "NavName",
                            new ColumnExpression()
                            {
                                Parameter = new Parameter()
                                {
                                    Value = $"Счет для {numberAgreement}",
                                    DataValueType = DataValueType.Text
                                },
                                ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.Parameter,
                            }

                        },

                        {
                            "NavAmount",
                            new ColumnExpression()
                            {
                                Parameter = new Parameter()
                                {
                                    Value = sumNewInvoice,
                                    DataValueType = DataValueType.Money
                                },
                                ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.Parameter,
                            }
                        },
                        {
                            "NavDate",
                            new ColumnExpression()
                            {
                            Parameter = new Parameter()
                            {
                                Value = $"\"{DateTime.Now.ToString("dd.MM.yyyy H:mm:ss")}\"",
                                DataValueType = DataValueType.Date
                            },
                            ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.Parameter,
                            }
                        },
                        {
                            "NavAgreement",
                            new ColumnExpression()
                            {
                            Parameter = new Parameter()
                            {
                                Value = idAgreement,
                                DataValueType = DataValueType.Lookup
                            },
                            ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.Parameter,
                            }
                        },
                        {
                            "NavInvoiceType",
                            new ColumnExpression()
                            {
                            Parameter = new Parameter()
                            {
                                Value = new Guid("81378EAF-61AD-4E17-ACBF-0EAED875AB65"),
                                DataValueType = DataValueType.Lookup
                            },
                            ExpressionType = Terrasoft.Core.Entities.EntitySchemaQueryExpressionType.Parameter,
                            }
                        },
                    },
                },

            };
            string json = JsonConvert.SerializeObject(insert);
            request.InsertRequest(json);

        }
    }
}