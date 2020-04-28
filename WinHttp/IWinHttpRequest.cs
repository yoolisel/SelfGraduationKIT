//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;

//namespace WinHttp
//{
//  [CompilerGenerated]
//  [Guid("016FE2EC-B2C8-45F8-B23B-39E53A75396B")]
//  [TypeIdentifier]
//  [ComImport]
//  public interface IWinHttpRequest
//  {
//    [SpecialName]
//    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
//    extern void _VtblGap1_2();

//    [DispId(1)]
//    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
//    void Open([MarshalAs(UnmanagedType.BStr), In] string Method, [MarshalAs(UnmanagedType.BStr), In] string Url, [MarshalAs(UnmanagedType.Struct), In, Optional] object Async);

//    [DispId(2)]
//    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
//    void SetRequestHeader([MarshalAs(UnmanagedType.BStr), In] string Header, [MarshalAs(UnmanagedType.BStr), In] string Value);

//    [SpecialName]
//    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
//    extern void _VtblGap2_2();

//    [DispId(5)]
//    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
//    void Send([MarshalAs(UnmanagedType.Struct), In, Optional] object Body);

//    [SpecialName]
//    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
//    extern void _VtblGap3_3();

//    [DispId(10)]
//    object ResponseBody { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

//    [SpecialName]
//    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
//    extern void _VtblGap4_3();

//    [DispId(15)]
//    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
//    bool WaitForResponse([MarshalAs(UnmanagedType.Struct), In, Optional] object Timeout);
//  }
//}
