﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Location.Model.Work
{
    /// <summary>
    /// 工作票
    /// </summary>
    public class WorkTicket
    {
        /// <summary>
        /// 工作票Id
        /// </summary>
        [DataMember]
        [Display(Name = "工作票Id")]
        public int Id { get; set; }

        /// <summary>
        /// 工作票编号
        /// </summary>
        [DataMember]
        [Display(Name = "工作票编号")]
        public string No { get; set; }

        /// <summary>
        /// 工作票负责人
        /// </summary>
        [DataMember]
        [Display(Name = "工作票负责人")]
        public string PersonInCharge { get; set; }

        /// <summary>
        /// 工作班负责人
        /// </summary>
        [DataMember]
        [Display(Name = "工作班负责人")]
        public string HeadOfWorkClass { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        [DataMember]
        [Display(Name = "工作地点")]
        public string WorkPlace { get; set; }

        /// <summary>
        /// 工作内容
        /// </summary>
        [DataMember]
        [Display(Name = "工作内容")]
        public string JobContent { get; set; }


        /// <summary>
        /// 安全措施
        /// </summary>
        [DataMember]
        [ForeignKey("WorkTicketId")]
        public virtual List<SafetyMeasures> SafetyMeasuress { get; set; }


        /// <summary>
        /// 计划工作时间（起始时间）
        /// </summary>
        [DataMember]
        [Display(Name = "计划工作时间（起始时间）")]
        public DateTime StartTimeOfPlannedWork { get; set; }

        /// <summary>
        /// 计划工作时间（结束时间）
        /// </summary>
        [DataMember]
        [Display(Name = "计划工作时间（结束时间）")]
        public DateTime EndTimeOfPlannedWork { get; set; }

        /// <summary>
        /// 工作条件
        /// </summary>
        [DataMember]
        [Display(Name = "工作条件")]
        public string WorkCondition { get; set; }

        /// <summary>
        /// 签发人
        /// </summary>
        [DataMember]
        [Display(Name = "签发人")]
        public string Lssuer { get; set; }

        /// <summary>
        /// 许可人
        /// </summary>
        [DataMember]
        [Display(Name = "许可人")]
        public string Licensor { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        [DataMember]
        [Display(Name = "审批人")]
        public string Approver { get; set; }

        /// <summary>
        /// 送电后评语
        /// </summary>
        [DataMember]
        [Display(Name = "送电后评语")]
        public string Comment { get; set; }
    }
}
