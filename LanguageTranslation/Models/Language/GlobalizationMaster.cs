using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LanguageTranslation.Models.LanguageTranslation
{
    public class GlobalizationMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        [ForeignKey("LanguageId")]
        public virtual LanguageMaster LanguageMaster { get; set; }
    }
}