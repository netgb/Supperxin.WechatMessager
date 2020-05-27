using System.Collections.Generic;

namespace Supperxin.WechatMessager.Model
{
    // {
    //   "dashboardId":1,
    //   "evalMatches":[
    //     {
    //       "value":1,
    //       "metric":"Count",
    //       "tags":{}
    //     }
    //   ],
    //   "imageUrl":"https://grafana.com/static/assets/img/blog/mixed_styles.png",
    //   "message":"Notification Message",
    //   "orgId":1,
    //   "panelId":2,
    //   "ruleId":1,
    //   "ruleName":"Panel Title alert",
    //   "ruleUrl":"http://localhost:3000/d/hZ7BuVbWz/test-dashboard?fullscreen\u0026edit\u0026tab=alert\u0026panelId=2\u0026orgId=1",
    //   "state":"alerting",
    //   "tags":{
    //     "tag name":"tag value"
    //   },
    //   "title":"[Alerting] Panel Title alert"
    // }
    public class GrafanaWebhookModel
    {
        public int dashboardId { get; set; }
        public object evalMatches { get; set; }
        public string imageUrl { get; set; }
        public string message { get; set; }
        public int orgId { get; set; }
        public int panelId { get; set; }
        public int ruleId { get; set; }
        public string ruleName { get; set; }
        public string ruleUrl { get; set; }
        public string state { get; set; }
        public Dictionary<string, string> tags { get; set; }
        public string title { get; set; }
    }
}
