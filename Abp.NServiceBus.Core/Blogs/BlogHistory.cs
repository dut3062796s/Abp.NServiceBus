﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.NServiceBus.Blogs
{
    public class BlogHistory : CreationAuditedEntity, IMustHaveTenant
    {

        public int TenantId { get; set; }

        [Required]
        public int BlogId { get; set; }

        [Required]
        public string Action { get; set; }

    }
}
