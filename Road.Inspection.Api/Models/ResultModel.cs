using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Road.Inspection.Api.Models
{
    public class ResultDto
    {
        public ResultDto()
        {
            status = true;
            message = "";
            data = null;
        }
        public ResultDto(bool status = true, string message = "", object data = null)
        {
            this.status = status;
            this.message = message;
            this.data = data;
        }
        public static ResultDto error(bool status = false, string msg = "")
        {
            ResultDto r = new ResultDto();
            r.status = status;
            r.message = msg;
            return r;
        }
        public static ResultDto success(bool status = true, string msg = "", object data = null)
        {
            ResultDto r = new ResultDto();
            r.status = status;
            r.message = msg;
            r.data = data;
            return r;
        }
        /// <summary>
        /// Хүсэлт амжилттай болсон тохиолдолд <b>true</b> утга буцаана
        /// </summary>
        [Required]
        public bool status { get; set; }
        /// <summary>
        /// Хүсэлтийн <b>status</b> ямар байхаас үл хамааран хүсэлт илгээгчид мэдээлэл өгөх зорилготой текст буцаана
        /// </summary>
        public string message { get; set; }
        public object data { set; get; }
    }
}