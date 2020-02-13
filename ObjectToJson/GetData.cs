using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ObjectToJson
{
    public static class GetData
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            InboundJsonData ib = new InboundJsonData
            {
                sendSynchronic = new SendSynchronicData
                {
                    sessionId = "db8d585e-ccc7-47af-826e-12kdiiied",
                    root = new SynchronicRootData
                    {
                        session = new List<List<SynchronicRootSession>>
                        {
                            new List<SynchronicRootSession>
                            {
                           new SynchronicRootSession
                           {
                               main = new SynchronicRootSessionMain
                               {
                                   row = new RowData
                                   {
                                       cause_descr = "cc_cause_descr",
                                                cause_id = "cause_id",
                                                open_date = "open_date",
                                                open_time = "open_time",
                                                work_order_id = "",
                                                problem_desc = "",
                                                eta_date = "",
                                                eta_time = "",
                                                code_id = "",
                                                site_company_id = "",
                                                site_company_descr = "",
                                                vendor1_nt = 2.0,
                                                priority = "",
                                                rfecode_id = "",
                                                postal_id = "",
                                                resolve_text = "",
                                                resolve_date = "",
                                                resolve_time = "",
                                                person_id = "",
                                                phone_id = "",
                                                cst_trade = "",
                                                condition = new RowDataCondition()
                                                {
                                                    ifThereData = new ConditionIfData()
                                                    {
                                                        left = "",
                                                        right = "op"
                                                    }
                                                }
                                   }
                               },
                               demand_labor = new List<SynchronicRootSessionDemand>
                               {
                                    new SynchronicRootSessionDemand
                                    {
                                        actual_dt = "actual_dt",
                                            actual_time = "actual_tm",
                                            arrive_dt = "",
                                            arrive_time = "",
                                            demand_id = "",
                                            code_id = "",
                                            person_id = "sa_person_id",
                                            part_id = "",
                                            comment_text = "",
                                            demand_stat_id = "",
                                            search_keys = new List<Search_Keys>
                                            {
                                                new Search_Keys
                                                {
                                                    name = "name1234",
                                                    value = ""
                                                }
                                            },
                                            condition = new ConditionIfDataDemand()
                                            {
                                                ifThereData = new IfDataDemand()
                                                {
                                                    left = "",
                                                    op = ""
                                                }
                                            }
                                    }
                               },
                               attribute = "1234567890"
                           }
                           }
                        }
                    }
                }
            };

            var json = JsonConvert.SerializeObject(ib);
           
            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            return name != null
                ? (ActionResult)new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
