//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODataResturantsService
{
    using System;
    using System.Collections.Generic;
    
    public partial class UploadAttachment
    {
        public int FileId { get; set; }
        public string fileName { get; set; }
        public string newFileName { get; set; }
        public string thumbnailName { get; set; }
        public string thumbnailLink { get; set; }
        public string name { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.Guid> userId { get; set; }
        public Nullable<System.Guid> LocationId { get; set; }
    }
}
