using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SelfGraduationKIT.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (SelfGraduationKIT.Properties.Resources.resourceMan == null)
          SelfGraduationKIT.Properties.Resources.resourceMan = new ResourceManager("SelfGraduationKIT.Properties.Resources", typeof (SelfGraduationKIT.Properties.Resources).Assembly);
        return SelfGraduationKIT.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return SelfGraduationKIT.Properties.Resources.resourceCulture;
      }
      set
      {
        SelfGraduationKIT.Properties.Resources.resourceCulture = value;
      }
    }

    internal static Bitmap _12311
    {
      get
      {
        return (Bitmap) SelfGraduationKIT.Properties.Resources.ResourceManager.GetObject("12311", SelfGraduationKIT.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap _2020_04_03_20_29_00
    {
      get
      {
        return (Bitmap) SelfGraduationKIT.Properties.Resources.ResourceManager.GetObject("2020-04-03 20;29;00", SelfGraduationKIT.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap _2020_04_03_20_30_22
    {
      get
      {
        return (Bitmap) SelfGraduationKIT.Properties.Resources.ResourceManager.GetObject("2020-04-03 20;30;22", SelfGraduationKIT.Properties.Resources.resourceCulture);
      }
    }
  }
}
