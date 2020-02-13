# C# object to nested JSON
This code helps to prepare a nested JSON from a C# Object.
This function app code serializes an Object into a nested JSON. I've created a class name Object.cs which has all the variables set. 
GetData.cs is the funaction app, that has the format that is set and converts the C# object to a nested JSON.
Below is the expected nested JSON output. (Note: Data is dummy data and for reference only.)

{
  "sendSynchronic": {
    "sessionId": "db8d585e-ccc7-47af-826e-12kdiiied",
    "root": {
      "session": [
        [
          {
            "main": {
              "row": {
                "cause_descr": "cc_cause_descr",
                "cause_id": "cause_id",
                "open_date": "open_date",
                "open_time": "open_time",
                "work_order_id": "",
                "problem_desc": "",
                "eta_date": "",
                "eta_time": "",
                "rfecode_id": "",
                "site_company_id": "",
                "site_company_descr": "",
                "vendor1_nt": 2,
                "priority": "",
                "code_id": "",
                "postal_id": "",
                "resolve_text": "",
                "resolve_date": "",
                "resolve_time": "",
                "person_id": "",
                "phone_id": "",
                "cst_trade": "",
                "condition": {
                  "if": {
                    "left": "",
                    "right": "op"
                  }
                }
              }
            },
            "demand_labor": [
              {
                "actual_dt": "actual_dt",
                "actual_time": "actual_tm",
                "arrive_dt": "",
                "arrive_time": "",
                "demand_id": "",
                "code_id": "",
                "person_id": "sa_person_id",
                "part_id": "",
                "comment_text": "",
                "demand_stat_id": "",
                "search_keys": [
                  {
                    "name": "name1234",
                    "value": ""
                  }
                ],
                "condition": {
                  "if": {
                    "left": "",
                    "op": ""
                  }
                }
              }
            ],
            "attribute": "1234567890"
          }
        ]
      ]
    }
  }
}
