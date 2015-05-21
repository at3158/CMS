using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
     [System.ComponentModel.DataAnnotations.MetadataType(typeof(PEOMetaData))]

    public partial class PEO
    {
         public class PEOMetaData
         {

             public string ID { get; set; }
             [DisplayName("名稱")]
             public string NAME { get; set; }
             [DisplayName("日期")]
             //public string CREATEDATE { get; set; }
             [DataType(DataType.Date)]
             public System.DateTime CREATEDATE { get; set; }
         }
    }

   
}