using System;
using System.Collections.Generic;

namespace BucketList_02_API.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string NameUser { get; set; } = null!;

    public string PassWordUser { get; set; } = null!;

    public virtual ICollection<Personalbucketlist> Personalbucketlists { get; set; } = new List<Personalbucketlist>();
}
