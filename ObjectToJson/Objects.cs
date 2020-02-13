using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectToJson
{
    #region PREPARE JSON DATA

    public class InboundJsonData
    {
        public SendSynchronicData sendSynchronic { get; set; }
    }

    public class SendSynchronicData
    {
        public string sessionId { get; set; }
        public SynchronicRootData root { get; set; }
    }

    public class SynchronicRootData
    {
        public List<List<SynchronicRootSession>> session { get; set; }
    }

    public class SynchronicRootSession
    {
        public SynchronicRootSessionMain main { get; set; }
        public List<SynchronicRootSessionDemand> demand_labor { get; set; }
        public string attribute { get; set; }
    }
        
    public class SynchronicRootSessionMain
    {
        public RowData row { get; set; }
    }

    public class JsonDataFormat
    {
        public SendSynchronicData sendSynchronic { get; set; }
    }

    public class RowData
    {
        public string cause_descr { get; set; }
        public string cause_id { get; set; }
        public string open_date { get; set; }
        public string open_time { get; set; }
        public string work_order_id { get; set; }
        public string problem_desc { get; set; }
        public string eta_date { get; set; }
        public string eta_time { get; set; }
        public string rfecode_id { get; set; }
        public string site_company_id { get; set; }
        public string site_company_descr { get; set; }
        public double vendor1_nt { get; set; }
        public string priority { get; set; }
        public string code_id { get; set; }
        public string postal_id { get; set; }
        public string resolve_text { get; set; }
        public string resolve_date { get; set; }
        public string resolve_time { get; set; }
        public string person_id { get; set; }
        public string phone_id { get; set; }
        public string cst_trade { get; set; }
        public RowDataCondition condition { get; set; }
    }

    public class RowDataCondition
    {
        [JsonProperty("if")]
        public ConditionIfData ifThereData { get; set; }
    }

    public class ConditionIfData
    {
        public string left { get; set; }
        public string right{ get; set; }
    }

    public class SynchronicRootSessionDemand
    {
        public string actual_dt { get; set; }
        public string actual_time { get; set; }
        public string arrive_dt { get; set; }
        public string arrive_time { get; set; }
        public string demand_id { get; set; }
        public string code_id { get; set; }
        public string person_id { get; set; }
        public string part_id { get; set; }
        public string comment_text { get; set; }
        public string demand_stat_id { get; set; }
        public List<Search_Keys> search_keys { get; set; }
        public ConditionIfDataDemand condition { get; set; }
    }

    public class Search_Keys
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class ConditionIfDataDemand
    {
        [JsonProperty("if")]
        public IfDataDemand ifThereData { get; set; }
    }

    public class IfDataDemand
    {
        public string left { get; set; }
        public string op { get; set; }
    }

    #endregion
}
