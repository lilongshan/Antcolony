//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.ProjectMessage = new HashSet<ProjectMessage>();
            this.ProjectFile = new HashSet<ProjectFile>();
            this.ProjectFileTag = new HashSet<ProjectFileTag>();
            this.User = new HashSet<User>();
            this.ProjectTaskList = new HashSet<ProjectTaskList>();
        }
    
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
        public short State { get; set; }
        public int MainUserId { get; set; }
        public int Teamid { get; set; }
        public string ProjectInfo { get; set; }
        public string ProjectImg { get; set; }
        public int SpeedOfProgress { get; set; }
        public string Edition { get; set; }
        public string GitHubUrl { get; set; }
        public short Priority { get; set; }
        public System.DateTime EstimatedTime { get; set; }
        public string WareHourseUrl { get; set; }
        public double Money { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectMessage> ProjectMessage { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectFile> ProjectFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectFileTag> ProjectFileTag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectTaskList> ProjectTaskList { get; set; }
        public virtual ProjectStateTable ProjectStateTable { get; set; }
    }
}
