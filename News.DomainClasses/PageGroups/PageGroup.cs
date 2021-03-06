﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace News.DomainClasses.PageGroups
{
    public record PageGroup
    {
        public PageGroup()
        {

        }
        [Key]
        public int GroupId { get; set; }
        [Required()]
        [MaxLength(200)]
        [Display(Name = "عنوان گروه")]
        
        public string GroupTitle { get; set; }

        public virtual ICollection<Page.Page> Pages { get; set; }
    }
}

