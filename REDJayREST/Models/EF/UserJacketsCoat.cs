﻿using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class UserJacketsCoat
    {
        public UserJacketsCoat()
        {
            UserUploads = new HashSet<UserUpload>();
        }

        public int PkJacketCoatId { get; set; }
        public string UploadStyle { get; set; } = null!;
        public string UploadBrand { get; set; } = null!;
        public int UploadSize { get; set; }
        public int UploadCondition { get; set; }
        public bool? InStock { get; set; }
        public bool AdminApproval { get; set; }

        public virtual ICollection<UserUpload> UserUploads { get; set; }
    }
}
