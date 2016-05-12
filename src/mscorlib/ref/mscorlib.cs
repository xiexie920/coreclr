namespace Microsoft.Win32.SafeHandles
{
    [System.Security.SecurityCriticalAttribute]
    public abstract partial class SafeHandleZeroOrMinusOneIsInvalid : System.Runtime.InteropServices.SafeHandle
    {
        internal SafeHandleZeroOrMinusOneIsInvalid() { }
        public override bool IsInvalid { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
    }
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class SafeWaitHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        
        public SafeWaitHandle(System.IntPtr existingHandle, bool ownsHandle) { }
        [System.Security.SecurityCriticalAttribute]
        protected override bool ReleaseHandle() { return default(bool); }
    }
}
namespace System
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AccessViolationException : System.SystemException
    {
        public AccessViolationException() { }
        public AccessViolationException(string message) { }
        public AccessViolationException(string message, System.Exception innerException) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate void Action();
    public delegate void Action<in T>(T obj);
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate void Action<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Activator
    {
        internal Activator() { }
        public static object CreateInstance(System.Type type) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static object CreateInstance(System.Type type, bool nonPublic) { return default(object); }
        public static object CreateInstance(System.Type type, params object[] args) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static T CreateInstance<T>() { return default(T); }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {InnerExceptionCount}")]
    public partial class AggregateException : System.Exception
    {
        public AggregateException() { }
        public AggregateException(System.Collections.Generic.IEnumerable<System.Exception> innerExceptions) { }
        public AggregateException(params System.Exception[] innerExceptions) { }
        public AggregateException(string message) { }
        public AggregateException(string message, System.Collections.Generic.IEnumerable<System.Exception> innerExceptions) { }
        public AggregateException(string message, System.Exception innerException) { }
        public AggregateException(string message, params System.Exception[] innerExceptions) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> InnerExceptions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>); } }
        public override string Message { get { return default(string); } }
        public System.AggregateException Flatten() { return default(System.AggregateException); }
        public override System.Exception GetBaseException() { return default(System.Exception); }
        public void Handle(System.Func<System.Exception, bool> predicate) { }
        public override string ToString() { return default(string); }
    }
    public static partial class AppContext
    {
        public static string BaseDirectory { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public static string TargetFrameworkName { get { return default(string); } }
        [System.Security.SecuritySafeCriticalAttribute]
        public static object GetData(string name) { return default(object); }
        public static void SetSwitch(string switchName, bool isEnabled) { }
        public static bool TryGetSwitch(string switchName, out bool isEnabled) { isEnabled = default(bool); return default(bool); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AppDomain
    {
        internal AppDomain() { }
        public string BaseDirectory { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
        public static System.AppDomain CurrentDomain { get { return default(System.AppDomain); } }
        public bool IsFullyTrusted { [System.Security.SecuritySafeCriticalAttribute]get { return default(bool); } }
        [System.Security.SecurityCriticalAttribute]
        public object GetData(string name) { return default(object); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public partial class AppDomainManager
    {
        public AppDomainManager() { }
        public virtual bool CheckSecuritySettings(System.Security.SecurityState state) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public virtual void InitializeNewDomain(System.AppDomainSetup appDomainInfo) { }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AppDomainSetup
    {
        internal AppDomainSetup() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AppDomainUnloadedException : System.SystemException
    {
        public AppDomainUnloadedException() { }
        public AppDomainUnloadedException(string message) { }
        public AppDomainUnloadedException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ApplicationException : System.Exception
    {
        public ApplicationException() { }
        public ApplicationException(string message) { }
        public ApplicationException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ArgIterator
    {
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ArgumentException : System.SystemException
    {
        public ArgumentException() { }
        public ArgumentException(string message) { }
        public ArgumentException(string message, System.Exception innerException) { }
        public ArgumentException(string message, string paramName) { }
        public ArgumentException(string message, string paramName, System.Exception innerException) { }
        public override string Message { get { return default(string); } }
        public virtual string ParamName { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ArgumentNullException : System.ArgumentException
    {
        public ArgumentNullException() { }
        public ArgumentNullException(string paramName) { }
        public ArgumentNullException(string message, System.Exception innerException) { }
        public ArgumentNullException(string paramName, string message) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ArgumentOutOfRangeException : System.ArgumentException
    {
        public ArgumentOutOfRangeException() { }
        public ArgumentOutOfRangeException(string paramName) { }
        public ArgumentOutOfRangeException(string message, System.Exception innerException) { }
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message) { }
        public ArgumentOutOfRangeException(string paramName, string message) { }
        public virtual object ActualValue { get { return default(object); } }
        public override string Message { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ArithmeticException : System.SystemException
    {
        public ArithmeticException() { }
        public ArithmeticException(string message) { }
        public ArithmeticException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Array : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable
    {
        internal Array() { }
        public bool IsFixedSize { get { return default(bool); } }
        public bool IsReadOnly { get { return default(bool); } }
        public bool IsSynchronized { get { return default(bool); } }
        public int Length { [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(int); } }
        public int Rank { [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(int); } }
        public object SyncRoot { get { return default(object); } }
        int System.Collections.ICollection.Count { get { return default(int); } }
        object System.Collections.IList.this[int index] { get { return default(object); } set { } }
        public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(T[] array) { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
        
        public static int BinarySearch(System.Array array, int index, int length, object value) { return default(int); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static int BinarySearch(System.Array array, int index, int length, object value, System.Collections.IComparer comparer) { return default(int); }
        
        public static int BinarySearch(System.Array array, object value) { return default(int); }
        
        public static int BinarySearch(System.Array array, object value, System.Collections.IComparer comparer) { return default(int); }
        
        public static int BinarySearch<T>(T[] array, T value) { return default(int); }
        
        public static int BinarySearch<T>(T[] array, T value, System.Collections.Generic.IComparer<T> comparer) { return default(int); }
        
        public static int BinarySearch<T>(T[] array, int index, int length, T value) { return default(int); }
        
        public static int BinarySearch<T>(T[] array, int index, int length, T value, System.Collections.Generic.IComparer<T> comparer) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Clear(System.Array array, int index, int length) { }
        public object Clone() { return default(object); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void ConstrainedCopy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Copy(System.Array sourceArray, System.Array destinationArray, int length) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Copy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length) { }
        public void CopyTo(System.Array array, int index) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Array CreateInstance(System.Type elementType, int length) { return default(System.Array); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Array CreateInstance(System.Type elementType, params int[] lengths) { return default(System.Array); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Array CreateInstance(System.Type elementType, int[] lengths, int[] lowerBounds) { return default(System.Array); }
        
        public static T[] Empty<T>() { return default(T[]); }
        public static bool Exists<T>(T[] array, System.Predicate<T> match) { return default(bool); }
        public static T Find<T>(T[] array, System.Predicate<T> match) { return default(T); }
        public static T[] FindAll<T>(T[] array, System.Predicate<T> match) { return default(T[]); }
        public static int FindIndex<T>(T[] array, int startIndex, int count, System.Predicate<T> match) { return default(int); }
        public static int FindIndex<T>(T[] array, int startIndex, System.Predicate<T> match) { return default(int); }
        public static int FindIndex<T>(T[] array, System.Predicate<T> match) { return default(int); }
        public static T FindLast<T>(T[] array, System.Predicate<T> match) { return default(T); }
        public static int FindLastIndex<T>(T[] array, int startIndex, int count, System.Predicate<T> match) { return default(int); }
        public static int FindLastIndex<T>(T[] array, int startIndex, System.Predicate<T> match) { return default(int); }
        public static int FindLastIndex<T>(T[] array, System.Predicate<T> match) { return default(int); }
        public static void ForEach<T>(T[] array, System.Action<T> action) { }
        public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public int GetLength(int dimension) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public int GetLowerBound(int dimension) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public int GetUpperBound(int dimension) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public object GetValue(int index) { return default(object); }
        [System.Security.SecuritySafeCriticalAttribute]
        public object GetValue(params int[] indices) { return default(object); }
        
        public static int IndexOf(System.Array array, object value) { return default(int); }
        
        public static int IndexOf(System.Array array, object value, int startIndex) { return default(int); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static int IndexOf(System.Array array, object value, int startIndex, int count) { return default(int); }
        public static int IndexOf<T>(T[] array, T value) { return default(int); }
        public static int IndexOf<T>(T[] array, T value, int startIndex) { return default(int); }
        public static int IndexOf<T>(T[] array, T value, int startIndex, int count) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public void Initialize() { }
        
        public static int LastIndexOf(System.Array array, object value) { return default(int); }
        
        public static int LastIndexOf(System.Array array, object value, int startIndex) { return default(int); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static int LastIndexOf(System.Array array, object value, int startIndex, int count) { return default(int); }
        public static int LastIndexOf<T>(T[] array, T value) { return default(int); }
        public static int LastIndexOf<T>(T[] array, T value, int startIndex) { return default(int); }
        public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) { return default(int); }
        
        public static void Resize<T>(ref T[] array, int newSize) { }
        
        public static void Reverse(System.Array array) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Reverse(System.Array array, int index, int length) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetValue(object value, int index) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetValue(object value, params int[] indices) { }
        
        public static void Sort(System.Array array) { }
        
        public static void Sort(System.Array keys, System.Array items) { }
        
        public static void Sort(System.Array keys, System.Array items, System.Collections.IComparer comparer) { }
        
        public static void Sort(System.Array keys, System.Array items, int index, int length) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Sort(System.Array keys, System.Array items, int index, int length, System.Collections.IComparer comparer) { }
        
        public static void Sort(System.Array array, System.Collections.IComparer comparer) { }
        
        public static void Sort(System.Array array, int index, int length) { }
        
        public static void Sort(System.Array array, int index, int length, System.Collections.IComparer comparer) { }
        
        public static void Sort<T>(T[] array) { }
        
        public static void Sort<T>(T[] array, System.Collections.Generic.IComparer<T> comparer) { }
        public static void Sort<T>(T[] array, System.Comparison<T> comparison) { }
        
        public static void Sort<T>(T[] array, int index, int length) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Sort<T>(T[] array, int index, int length, System.Collections.Generic.IComparer<T> comparer) { }
        
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items) { }
        
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, System.Collections.Generic.IComparer<TKey> comparer) { }
        
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, System.Collections.Generic.IComparer<TKey> comparer) { }
        int System.Collections.IList.Add(object value) { return default(int); }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { return default(bool); }
        int System.Collections.IList.IndexOf(object value) { return default(int); }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        public static bool TrueForAll<T>(T[] array, System.Predicate<T> match) { return default(bool); }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ArraySegment<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.IEnumerable
    {
        public ArraySegment(T[] array) { throw new System.NotImplementedException(); }
        public ArraySegment(T[] array, int offset, int count) { throw new System.NotImplementedException(); }
        public T[] Array { get { return default(T[]); } }
        public int Count { get { return default(int); } }
        public int Offset { get { return default(int); } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
        T System.Collections.Generic.IList<T>.this[int index] { get { return default(T); } set { } }
        T System.Collections.Generic.IReadOnlyList<T>.this[int index] { get { return default(T); } }
        public bool Equals(System.ArraySegment<T> obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.ArraySegment<T> a, System.ArraySegment<T> b) { return default(bool); }
        public static bool operator !=(System.ArraySegment<T> a, System.ArraySegment<T> b) { return default(bool); }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.ICollection<T>.Clear() { }
        bool System.Collections.Generic.ICollection<T>.Contains(T item) { return default(bool); }
        void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<T>.Remove(T item) { return default(bool); }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
        int System.Collections.Generic.IList<T>.IndexOf(T item) { return default(int); }
        void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ArrayTypeMismatchException : System.SystemException
    {
        public ArrayTypeMismatchException() { }
        public ArrayTypeMismatchException(string message) { }
        public ArrayTypeMismatchException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void AsyncCallback(System.IAsyncResult ar);
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited=true, AllowMultiple=false)]
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Attribute
    {
        protected Attribute() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        public static System.Attribute GetCustomAttribute(System.Reflection.Assembly element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(System.Reflection.Assembly element, System.Type attributeType, bool inherit) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(System.Reflection.MemberInfo element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(System.Reflection.Module element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(System.Reflection.Module element, System.Type attributeType, bool inherit) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(System.Reflection.ParameterInfo element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { return default(System.Attribute); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element, bool inherit) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element, System.Type attributeType) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element, System.Type attributeType, bool inherit) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, bool inherit) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, System.Type type) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, System.Type type, bool inherit) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element, bool inherit) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element, System.Type attributeType) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element, System.Type attributeType, bool inherit) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, bool inherit) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, System.Type attributeType) { return default(System.Attribute[]); }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { return default(System.Attribute[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public static bool IsDefined(System.Reflection.Assembly element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(System.Reflection.Assembly element, System.Type attributeType, bool inherit) { return default(bool); }
        public static bool IsDefined(System.Reflection.MemberInfo element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { return default(bool); }
        public static bool IsDefined(System.Reflection.Module element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(System.Reflection.Module element, System.Type attributeType, bool inherit) { return default(bool); }
        public static bool IsDefined(System.Reflection.ParameterInfo element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { return default(bool); }
        public virtual bool Match(object obj) { return default(bool); }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum AttributeTargets
    {
        All = 32767,
        Assembly = 1,
        Class = 4,
        Constructor = 32,
        Delegate = 4096,
        Enum = 16,
        Event = 512,
        Field = 256,
        GenericParameter = 16384,
        Interface = 1024,
        Method = 64,
        Module = 2,
        Parameter = 2048,
        Property = 128,
        ReturnValue = 8192,
        Struct = 8,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AttributeUsageAttribute : System.Attribute
    {
        public AttributeUsageAttribute(System.AttributeTargets validOn) { }
        public bool AllowMultiple { get { return default(bool); } set { } }
        public bool Inherited { get { return default(bool); } set { } }
        public System.AttributeTargets ValidOn { get { return default(System.AttributeTargets); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BadImageFormatException : System.SystemException
    {
        public BadImageFormatException() { }
        public BadImageFormatException(string message) { }
        public BadImageFormatException(string message, System.Exception inner) { }
        public BadImageFormatException(string message, string fileName) { }
        public BadImageFormatException(string message, string fileName, System.Exception inner) { }
        public string FileName { get { return default(string); } }
        public override string Message { get { return default(string); } }
        public override string ToString() { return default(string); }
    }
    public static partial class BitConverter
    {
        public static readonly bool IsLittleEndian;
        [System.Security.SecuritySafeCriticalAttribute]
        public static long DoubleToInt64Bits(double value) { return default(long); }
        public static byte[] GetBytes(bool value) { return default(byte[]); }
        public static byte[] GetBytes(char value) { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] GetBytes(double value) { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] GetBytes(short value) { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] GetBytes(int value) { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] GetBytes(long value) { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] GetBytes(float value) { return default(byte[]); }
        [System.CLSCompliantAttribute(false)]
        public static byte[] GetBytes(ushort value) { return default(byte[]); }
        [System.CLSCompliantAttribute(false)]
        public static byte[] GetBytes(uint value) { return default(byte[]); }
        [System.CLSCompliantAttribute(false)]
        public static byte[] GetBytes(ulong value) { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static double Int64BitsToDouble(long value) { return default(double); }
        public static bool ToBoolean(byte[] value, int startIndex) { return default(bool); }
        public static char ToChar(byte[] value, int startIndex) { return default(char); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static double ToDouble(byte[] value, int startIndex) { return default(double); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static short ToInt16(byte[] value, int startIndex) { return default(short); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int ToInt32(byte[] value, int startIndex) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static long ToInt64(byte[] value, int startIndex) { return default(long); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static float ToSingle(byte[] value, int startIndex) { return default(float); }
        public static string ToString(byte[] value) { return default(string); }
        public static string ToString(byte[] value, int startIndex) { return default(string); }
        public static string ToString(byte[] value, int startIndex, int length) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(byte[] value, int startIndex) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(byte[] value, int startIndex) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(byte[] value, int startIndex) { return default(ulong); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Boolean : System.IComparable, System.IComparable<bool>, System.IConvertible, System.IEquatable<bool>
    {
        public static readonly string FalseString;
        public static readonly string TrueString;
        public int CompareTo(bool value) { return default(int); }
        public int CompareTo(object obj) { return default(int); }
        
        public bool Equals(bool obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public static bool Parse(string value) { return default(bool); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        public override string ToString() { return default(string); }
        public string ToString(System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string value, out bool result) { result = default(bool); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class Buffer
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static void BlockCopy(System.Array src, int srcOffset, System.Array dst, int dstOffset, int count) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int ByteLength(System.Array array) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte GetByte(System.Array array, int index) { return default(byte); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)][System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)][System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe static void MemoryCopy(void* source, void* destination, ulong destinationSizeInBytes, ulong sourceBytesToCopy) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void SetByte(System.Array array, int index, byte value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Byte : System.IComparable, System.IComparable<byte>, System.IConvertible, System.IEquatable<byte>, System.IFormattable
    {
        public const byte MaxValue = (byte)255;
        public const byte MinValue = (byte)0;
        public int CompareTo(byte value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        
        public bool Equals(byte obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public static byte Parse(string s) { return default(byte); }
        public static byte Parse(string s, System.Globalization.NumberStyles style) { return default(byte); }
        public static byte Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(byte); }
        public static byte Parse(string s, System.IFormatProvider provider) { return default(byte); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string s, out byte result) { result = default(byte); return default(bool); }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out byte result) { result = default(byte); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CannotUnloadAppDomainException : System.SystemException
    {
        public CannotUnloadAppDomainException() { }
        public CannotUnloadAppDomainException(string message) { }
        public CannotUnloadAppDomainException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Char : System.IComparable, System.IComparable<char>, System.IConvertible, System.IEquatable<char>
    {
        public const char MaxValue = '\uFFFF';
        public const char MinValue = '\0';
        public int CompareTo(char value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        public static string ConvertFromUtf32(int utf32) { return default(string); }
        public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { return default(int); }
        public static int ConvertToUtf32(string s, int index) { return default(int); }
        
        public bool Equals(char obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static double GetNumericValue(char c) { return default(double); }
        public static double GetNumericValue(string s, int index) { return default(double); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(char c) { return default(System.Globalization.UnicodeCategory); }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(string s, int index) { return default(System.Globalization.UnicodeCategory); }
        public static bool IsControl(char c) { return default(bool); }
        public static bool IsControl(string s, int index) { return default(bool); }
        public static bool IsDigit(char c) { return default(bool); }
        public static bool IsDigit(string s, int index) { return default(bool); }
        public static bool IsHighSurrogate(char c) { return default(bool); }
        public static bool IsHighSurrogate(string s, int index) { return default(bool); }
        public static bool IsLetter(char c) { return default(bool); }
        public static bool IsLetter(string s, int index) { return default(bool); }
        public static bool IsLetterOrDigit(char c) { return default(bool); }
        public static bool IsLetterOrDigit(string s, int index) { return default(bool); }
        public static bool IsLower(char c) { return default(bool); }
        public static bool IsLower(string s, int index) { return default(bool); }
        public static bool IsLowSurrogate(char c) { return default(bool); }
        public static bool IsLowSurrogate(string s, int index) { return default(bool); }
        public static bool IsNumber(char c) { return default(bool); }
        public static bool IsNumber(string s, int index) { return default(bool); }
        public static bool IsPunctuation(char c) { return default(bool); }
        public static bool IsPunctuation(string s, int index) { return default(bool); }
        public static bool IsSeparator(char c) { return default(bool); }
        public static bool IsSeparator(string s, int index) { return default(bool); }
        public static bool IsSurrogate(char c) { return default(bool); }
        public static bool IsSurrogate(string s, int index) { return default(bool); }
        public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { return default(bool); }
        public static bool IsSurrogatePair(string s, int index) { return default(bool); }
        public static bool IsSymbol(char c) { return default(bool); }
        public static bool IsSymbol(string s, int index) { return default(bool); }
        public static bool IsUpper(char c) { return default(bool); }
        public static bool IsUpper(string s, int index) { return default(bool); }
        public static bool IsWhiteSpace(char c) { return default(bool); }
        public static bool IsWhiteSpace(string s, int index) { return default(bool); }
        public static char Parse(string s) { return default(char); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        public static char ToLower(char c) { return default(char); }
        public static char ToLower(char c, System.Globalization.CultureInfo culture) { return default(char); }
        public static char ToLowerInvariant(char c) { return default(char); }
        public override string ToString() { return default(string); }
        public static string ToString(char c) { return default(string); }
        public string ToString(System.IFormatProvider provider) { return default(string); }
        public static char ToUpper(char c) { return default(char); }
        public static char ToUpper(char c, System.Globalization.CultureInfo culture) { return default(char); }
        public static char ToUpperInvariant(char c) { return default(char); }
        public static bool TryParse(string s, out char result) { result = default(char); return default(bool); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited=true, AllowMultiple=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class CLSCompliantAttribute : System.Attribute
    {
        public CLSCompliantAttribute(bool isCompliant) { }
        public bool IsCompliant { get { return default(bool); } }
    }
    public delegate int Comparison<in T>(T x, T y);
    public static partial class Console
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Write(string s) { }
        public static void WriteLine() { }
        public static void WriteLine(string s) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ContextMarshalException : System.SystemException
    {
        public ContextMarshalException() { }
        public ContextMarshalException(string message) { }
        public ContextMarshalException(string message, System.Exception inner) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false)]
    [System.ObsoleteAttribute("ContextStaticAttribute is not supported in this release. It has been left in so that legacy tools can be used with this release, but it cannot be used in your code.", true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ContextStaticAttribute : System.Attribute
    {
        public ContextStaticAttribute() { }
    }
    public static partial class Convert
    {
        public static readonly object DBNull;
        public static object ChangeType(object value, System.Type conversionType) { return default(object); }
        public static object ChangeType(object value, System.Type conversionType, System.IFormatProvider provider) { return default(object); }
        public static object ChangeType(object value, System.TypeCode typeCode, System.IFormatProvider provider) { return default(object); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] FromBase64String(string s) { return default(byte[]); }
        public static System.TypeCode GetTypeCode(object value) { return default(System.TypeCode); }
        public static bool IsDBNull(object value) { return default(bool); }
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { return default(int); }
        public static string ToBase64String(byte[] inArray) { return default(string); }
        public static string ToBase64String(byte[] inArray, int offset, int length) { return default(string); }
        public static bool ToBoolean(bool value) { return default(bool); }
        public static bool ToBoolean(byte value) { return default(bool); }
        public static bool ToBoolean(char value) { return default(bool); }
        public static bool ToBoolean(decimal value) { return default(bool); }
        public static bool ToBoolean(double value) { return default(bool); }
        public static bool ToBoolean(short value) { return default(bool); }
        public static bool ToBoolean(int value) { return default(bool); }
        public static bool ToBoolean(long value) { return default(bool); }
        public static bool ToBoolean(object value) { return default(bool); }
        public static bool ToBoolean(object value, System.IFormatProvider provider) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(sbyte value) { return default(bool); }
        public static bool ToBoolean(float value) { return default(bool); }
        public static bool ToBoolean(string value) { return default(bool); }
        public static bool ToBoolean(string value, System.IFormatProvider provider) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(ushort value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(uint value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(ulong value) { return default(bool); }
        public static byte ToByte(bool value) { return default(byte); }
        public static byte ToByte(byte value) { return default(byte); }
        public static byte ToByte(char value) { return default(byte); }
        public static byte ToByte(decimal value) { return default(byte); }
        public static byte ToByte(double value) { return default(byte); }
        public static byte ToByte(short value) { return default(byte); }
        public static byte ToByte(int value) { return default(byte); }
        public static byte ToByte(long value) { return default(byte); }
        public static byte ToByte(object value) { return default(byte); }
        public static byte ToByte(object value, System.IFormatProvider provider) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(sbyte value) { return default(byte); }
        public static byte ToByte(float value) { return default(byte); }
        public static byte ToByte(string value) { return default(byte); }
        public static byte ToByte(string value, System.IFormatProvider provider) { return default(byte); }
        public static byte ToByte(string value, int fromBase) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(ushort value) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(uint value) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(ulong value) { return default(byte); }
        public static char ToChar(byte value) { return default(char); }
        public static char ToChar(char value) { return default(char); }
        public static char ToChar(decimal value) { return default(char); }
        public static char ToChar(double value) { return default(char); }
        public static char ToChar(short value) { return default(char); }
        public static char ToChar(int value) { return default(char); }
        public static char ToChar(long value) { return default(char); }
        public static char ToChar(object value) { return default(char); }
        public static char ToChar(object value, System.IFormatProvider provider) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(sbyte value) { return default(char); }
        public static char ToChar(float value) { return default(char); }
        public static char ToChar(string value) { return default(char); }
        public static char ToChar(string value, System.IFormatProvider provider) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(ushort value) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(uint value) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(ulong value) { return default(char); }
        public static System.DateTime ToDateTime(object value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(object value, System.IFormatProvider provider) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(string value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(string value, System.IFormatProvider provider) { return default(System.DateTime); }
        public static decimal ToDecimal(bool value) { return default(decimal); }
        public static decimal ToDecimal(byte value) { return default(decimal); }
        public static decimal ToDecimal(char value) { return default(decimal); }
        public static decimal ToDecimal(System.DateTime value) { return default(decimal); }
        public static decimal ToDecimal(decimal value) { return default(decimal); }
        public static decimal ToDecimal(double value) { return default(decimal); }
        public static decimal ToDecimal(short value) { return default(decimal); }
        public static decimal ToDecimal(int value) { return default(decimal); }
        public static decimal ToDecimal(long value) { return default(decimal); }
        public static decimal ToDecimal(object value) { return default(decimal); }
        public static decimal ToDecimal(object value, System.IFormatProvider provider) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(sbyte value) { return default(decimal); }
        public static decimal ToDecimal(float value) { return default(decimal); }
        public static decimal ToDecimal(string value) { return default(decimal); }
        public static decimal ToDecimal(string value, System.IFormatProvider provider) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(ushort value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(uint value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(ulong value) { return default(decimal); }
        public static double ToDouble(bool value) { return default(double); }
        public static double ToDouble(byte value) { return default(double); }
        public static double ToDouble(char value) { return default(double); }
        public static double ToDouble(decimal value) { return default(double); }
        public static double ToDouble(double value) { return default(double); }
        public static double ToDouble(short value) { return default(double); }
        public static double ToDouble(int value) { return default(double); }
        public static double ToDouble(long value) { return default(double); }
        public static double ToDouble(object value) { return default(double); }
        public static double ToDouble(object value, System.IFormatProvider provider) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(sbyte value) { return default(double); }
        public static double ToDouble(float value) { return default(double); }
        public static double ToDouble(string value) { return default(double); }
        public static double ToDouble(string value, System.IFormatProvider provider) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(ushort value) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(uint value) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(ulong value) { return default(double); }
        public static short ToInt16(bool value) { return default(short); }
        public static short ToInt16(byte value) { return default(short); }
        public static short ToInt16(char value) { return default(short); }
        public static short ToInt16(decimal value) { return default(short); }
        public static short ToInt16(double value) { return default(short); }
        public static short ToInt16(short value) { return default(short); }
        public static short ToInt16(int value) { return default(short); }
        public static short ToInt16(long value) { return default(short); }
        public static short ToInt16(object value) { return default(short); }
        public static short ToInt16(object value, System.IFormatProvider provider) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(sbyte value) { return default(short); }
        public static short ToInt16(float value) { return default(short); }
        public static short ToInt16(string value) { return default(short); }
        public static short ToInt16(string value, System.IFormatProvider provider) { return default(short); }
        public static short ToInt16(string value, int fromBase) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(ushort value) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(uint value) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(ulong value) { return default(short); }
        public static int ToInt32(bool value) { return default(int); }
        public static int ToInt32(byte value) { return default(int); }
        public static int ToInt32(char value) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int ToInt32(decimal value) { return default(int); }
        public static int ToInt32(double value) { return default(int); }
        public static int ToInt32(short value) { return default(int); }
        public static int ToInt32(int value) { return default(int); }
        public static int ToInt32(long value) { return default(int); }
        public static int ToInt32(object value) { return default(int); }
        public static int ToInt32(object value, System.IFormatProvider provider) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(sbyte value) { return default(int); }
        public static int ToInt32(float value) { return default(int); }
        public static int ToInt32(string value) { return default(int); }
        public static int ToInt32(string value, System.IFormatProvider provider) { return default(int); }
        public static int ToInt32(string value, int fromBase) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(ushort value) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(uint value) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(ulong value) { return default(int); }
        public static long ToInt64(bool value) { return default(long); }
        public static long ToInt64(byte value) { return default(long); }
        public static long ToInt64(char value) { return default(long); }
        public static long ToInt64(decimal value) { return default(long); }
        public static long ToInt64(double value) { return default(long); }
        public static long ToInt64(short value) { return default(long); }
        public static long ToInt64(int value) { return default(long); }
        public static long ToInt64(long value) { return default(long); }
        public static long ToInt64(object value) { return default(long); }
        public static long ToInt64(object value, System.IFormatProvider provider) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(sbyte value) { return default(long); }
        public static long ToInt64(float value) { return default(long); }
        public static long ToInt64(string value) { return default(long); }
        public static long ToInt64(string value, System.IFormatProvider provider) { return default(long); }
        public static long ToInt64(string value, int fromBase) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(ushort value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(uint value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(ulong value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(bool value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(byte value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(char value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(decimal value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(double value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(short value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(int value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(long value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(object value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(object value, System.IFormatProvider provider) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(sbyte value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(float value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value, System.IFormatProvider provider) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value, int fromBase) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(ushort value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(uint value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(ulong value) { return default(sbyte); }
        public static float ToSingle(bool value) { return default(float); }
        public static float ToSingle(byte value) { return default(float); }
        public static float ToSingle(char value) { return default(float); }
        public static float ToSingle(decimal value) { return default(float); }
        public static float ToSingle(double value) { return default(float); }
        public static float ToSingle(short value) { return default(float); }
        public static float ToSingle(int value) { return default(float); }
        public static float ToSingle(long value) { return default(float); }
        public static float ToSingle(object value) { return default(float); }
        public static float ToSingle(object value, System.IFormatProvider provider) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(sbyte value) { return default(float); }
        public static float ToSingle(float value) { return default(float); }
        public static float ToSingle(string value) { return default(float); }
        public static float ToSingle(string value, System.IFormatProvider provider) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(ushort value) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(uint value) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(ulong value) { return default(float); }
        public static string ToString(bool value) { return default(string); }
        public static string ToString(bool value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(byte value) { return default(string); }
        public static string ToString(byte value, System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string ToString(byte value, int toBase) { return default(string); }
        public static string ToString(char value) { return default(string); }
        public static string ToString(char value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(System.DateTime value) { return default(string); }
        public static string ToString(System.DateTime value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(decimal value) { return default(string); }
        public static string ToString(decimal value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(double value) { return default(string); }
        public static string ToString(double value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(short value) { return default(string); }
        public static string ToString(short value, System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string ToString(short value, int toBase) { return default(string); }
        public static string ToString(int value) { return default(string); }
        public static string ToString(int value, System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string ToString(int value, int toBase) { return default(string); }
        public static string ToString(long value) { return default(string); }
        public static string ToString(long value, System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string ToString(long value, int toBase) { return default(string); }
        public static string ToString(object value) { return default(string); }
        public static string ToString(object value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(float value) { return default(string); }
        public static string ToString(float value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(bool value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(byte value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(char value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(decimal value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(double value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(short value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(int value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(long value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(object value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(object value, System.IFormatProvider provider) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(sbyte value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(float value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value, System.IFormatProvider provider) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value, int fromBase) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(ushort value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(uint value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(ulong value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(bool value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(byte value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(char value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(decimal value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(double value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(short value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(int value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(long value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(object value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(object value, System.IFormatProvider provider) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(sbyte value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(float value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value, System.IFormatProvider provider) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value, int fromBase) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(ushort value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(uint value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(ulong value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(bool value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(byte value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(char value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(decimal value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(double value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(short value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(int value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(long value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(object value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(object value, System.IFormatProvider provider) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(sbyte value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(float value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value, System.IFormatProvider provider) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value, int fromBase) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(ushort value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(uint value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(ulong value) { return default(ulong); }
    }
    public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DataMisalignedException : System.SystemException
    {
        public DataMisalignedException() { }
        public DataMisalignedException(string message) { }
        public DataMisalignedException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Auto)]
    public partial struct DateTime : System.IComparable, System.IComparable<System.DateTime>, System.IConvertible, System.IEquatable<System.DateTime>, System.IFormattable
    {
        public static readonly System.DateTime MaxValue;
        public static readonly System.DateTime MinValue;
        public DateTime(int year, int month, int day) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, System.Globalization.Calendar calendar) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, int hour, int minute, int second) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, int hour, int minute, int second, System.DateTimeKind kind) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, int hour, int minute, int second, System.Globalization.Calendar calendar) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.DateTimeKind kind) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar) { throw new System.NotImplementedException(); }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar, System.DateTimeKind kind) { throw new System.NotImplementedException(); }
        public DateTime(long ticks) { throw new System.NotImplementedException(); }
        public DateTime(long ticks, System.DateTimeKind kind) { throw new System.NotImplementedException(); }
        public System.DateTime Date { get { return default(System.DateTime); } }
        public int Day { get { return default(int); } }
        public System.DayOfWeek DayOfWeek { get { return default(System.DayOfWeek); } }
        public int DayOfYear { get { return default(int); } }
        public int Hour { get { return default(int); } }
        public System.DateTimeKind Kind { get { return default(System.DateTimeKind); } }
        public int Millisecond { get { return default(int); } }
        public int Minute { get { return default(int); } }
        public int Month { get { return default(int); } }
        public static System.DateTime Now { get { return default(System.DateTime); } }
        public int Second { get { return default(int); } }
        public long Ticks { get { return default(long); } }
        public System.TimeSpan TimeOfDay { get { return default(System.TimeSpan); } }
        public static System.DateTime Today { get { return default(System.DateTime); } }
        public static System.DateTime UtcNow { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.DateTime); } }
        public int Year { get { return default(int); } }
        public System.DateTime Add(System.TimeSpan value) { return default(System.DateTime); }
        public System.DateTime AddDays(double value) { return default(System.DateTime); }
        public System.DateTime AddHours(double value) { return default(System.DateTime); }
        public System.DateTime AddMilliseconds(double value) { return default(System.DateTime); }
        public System.DateTime AddMinutes(double value) { return default(System.DateTime); }
        public System.DateTime AddMonths(int months) { return default(System.DateTime); }
        public System.DateTime AddSeconds(double value) { return default(System.DateTime); }
        public System.DateTime AddTicks(long value) { return default(System.DateTime); }
        public System.DateTime AddYears(int value) { return default(System.DateTime); }
        public static int Compare(System.DateTime t1, System.DateTime t2) { return default(int); }
        public int CompareTo(System.DateTime value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        public static int DaysInMonth(int year, int month) { return default(int); }
        public bool Equals(System.DateTime value) { return default(bool); }
        public static bool Equals(System.DateTime t1, System.DateTime t2) { return default(bool); }
        public override bool Equals(object value) { return default(bool); }
        public static System.DateTime FromBinary(long dateData) { return default(System.DateTime); }
        public static System.DateTime FromFileTime(long fileTime) { return default(System.DateTime); }
        public static System.DateTime FromFileTimeUtc(long fileTime) { return default(System.DateTime); }
        public static System.DateTime FromOADate(double d) { return default(System.DateTime); }
        public string[] GetDateTimeFormats() { return default(string[]); }
        public string[] GetDateTimeFormats(char format) { return default(string[]); }
        public string[] GetDateTimeFormats(char format, System.IFormatProvider provider) { return default(string[]); }
        public string[] GetDateTimeFormats(System.IFormatProvider provider) { return default(string[]); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public bool IsDaylightSavingTime() { return default(bool); }
        public static bool IsLeapYear(int year) { return default(bool); }
        public static System.DateTime operator +(System.DateTime d, System.TimeSpan t) { return default(System.DateTime); }
        public static bool operator ==(System.DateTime d1, System.DateTime d2) { return default(bool); }
        public static bool operator >(System.DateTime t1, System.DateTime t2) { return default(bool); }
        public static bool operator >=(System.DateTime t1, System.DateTime t2) { return default(bool); }
        public static bool operator !=(System.DateTime d1, System.DateTime d2) { return default(bool); }
        public static bool operator <(System.DateTime t1, System.DateTime t2) { return default(bool); }
        public static bool operator <=(System.DateTime t1, System.DateTime t2) { return default(bool); }
        public static System.TimeSpan operator -(System.DateTime d1, System.DateTime d2) { return default(System.TimeSpan); }
        public static System.DateTime operator -(System.DateTime d, System.TimeSpan t) { return default(System.DateTime); }
        public static System.DateTime Parse(string s) { return default(System.DateTime); }
        public static System.DateTime Parse(string s, System.IFormatProvider provider) { return default(System.DateTime); }
        public static System.DateTime Parse(string s, System.IFormatProvider provider, System.Globalization.DateTimeStyles styles) { return default(System.DateTime); }
        public static System.DateTime ParseExact(string s, string format, System.IFormatProvider provider) { return default(System.DateTime); }
        public static System.DateTime ParseExact(string s, string format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style) { return default(System.DateTime); }
        public static System.DateTime ParseExact(string s, string[] formats, System.IFormatProvider provider, System.Globalization.DateTimeStyles style) { return default(System.DateTime); }
        public static System.DateTime SpecifyKind(System.DateTime value, System.DateTimeKind kind) { return default(System.DateTime); }
        public System.TimeSpan Subtract(System.DateTime value) { return default(System.TimeSpan); }
        public System.DateTime Subtract(System.TimeSpan value) { return default(System.DateTime); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        public long ToBinary() { return default(long); }
        public long ToFileTime() { return default(long); }
        public long ToFileTimeUtc() { return default(long); }
        public System.DateTime ToLocalTime() { return default(System.DateTime); }
        public string ToLongDateString() { return default(string); }
        public string ToLongTimeString() { return default(string); }
        public double ToOADate() { return default(double); }
        public string ToShortDateString() { return default(string); }
        public string ToShortTimeString() { return default(string); }
        public override string ToString() { return default(string); }
        public string ToString(System.IFormatProvider provider) { return default(string); }
        public string ToString(string format) { return default(string); }
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public System.DateTime ToUniversalTime() { return default(System.DateTime); }
        public static bool TryParse(string s, out System.DateTime result) { result = default(System.DateTime); return default(bool); }
        public static bool TryParse(string s, System.IFormatProvider provider, System.Globalization.DateTimeStyles styles, out System.DateTime result) { result = default(System.DateTime); return default(bool); }
        public static bool TryParseExact(string s, string format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style, out System.DateTime result) { result = default(System.DateTime); return default(bool); }
        public static bool TryParseExact(string s, string[] formats, System.IFormatProvider provider, System.Globalization.DateTimeStyles style, out System.DateTime result) { result = default(System.DateTime); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DateTimeKind
    {
        Local = 2,
        Unspecified = 0,
        Utc = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Auto)]
    public partial struct DateTimeOffset : System.IComparable, System.IComparable<System.DateTimeOffset>, System.IEquatable<System.DateTimeOffset>, System.IFormattable
    {
        public static readonly System.DateTimeOffset MaxValue;
        public static readonly System.DateTimeOffset MinValue;
        public DateTimeOffset(System.DateTime dateTime) { throw new System.NotImplementedException(); }
        public DateTimeOffset(System.DateTime dateTime, System.TimeSpan offset) { throw new System.NotImplementedException(); }
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar, System.TimeSpan offset) { throw new System.NotImplementedException(); }
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, System.TimeSpan offset) { throw new System.NotImplementedException(); }
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, System.TimeSpan offset) { throw new System.NotImplementedException(); }
        public DateTimeOffset(long ticks, System.TimeSpan offset) { throw new System.NotImplementedException(); }
        public System.DateTime Date { get { return default(System.DateTime); } }
        public System.DateTime DateTime { get { return default(System.DateTime); } }
        public int Day { get { return default(int); } }
        public System.DayOfWeek DayOfWeek { get { return default(System.DayOfWeek); } }
        public int DayOfYear { get { return default(int); } }
        public int Hour { get { return default(int); } }
        public System.DateTime LocalDateTime { get { return default(System.DateTime); } }
        public int Millisecond { get { return default(int); } }
        public int Minute { get { return default(int); } }
        public int Month { get { return default(int); } }
        public static System.DateTimeOffset Now { get { return default(System.DateTimeOffset); } }
        public System.TimeSpan Offset { get { return default(System.TimeSpan); } }
        public int Second { get { return default(int); } }
        public long Ticks { get { return default(long); } }
        public System.TimeSpan TimeOfDay { get { return default(System.TimeSpan); } }
        public System.DateTime UtcDateTime { get { return default(System.DateTime); } }
        public static System.DateTimeOffset UtcNow { get { return default(System.DateTimeOffset); } }
        public long UtcTicks { get { return default(long); } }
        public int Year { get { return default(int); } }
        public System.DateTimeOffset Add(System.TimeSpan timeSpan) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddDays(double days) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddHours(double hours) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddMilliseconds(double milliseconds) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddMinutes(double minutes) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddMonths(int months) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddSeconds(double seconds) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddTicks(long ticks) { return default(System.DateTimeOffset); }
        public System.DateTimeOffset AddYears(int years) { return default(System.DateTimeOffset); }
        public static int Compare(System.DateTimeOffset first, System.DateTimeOffset second) { return default(int); }
        public int CompareTo(System.DateTimeOffset other) { return default(int); }
        public bool Equals(System.DateTimeOffset other) { return default(bool); }
        public static bool Equals(System.DateTimeOffset first, System.DateTimeOffset second) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public bool EqualsExact(System.DateTimeOffset other) { return default(bool); }
        public static System.DateTimeOffset FromFileTime(long fileTime) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset FromUnixTimeMilliseconds(long milliseconds) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset FromUnixTimeSeconds(long seconds) { return default(System.DateTimeOffset); }
        public override int GetHashCode() { return default(int); }
        public static System.DateTimeOffset operator +(System.DateTimeOffset dateTimeOffset, System.TimeSpan timeSpan) { return default(System.DateTimeOffset); }
        public static bool operator ==(System.DateTimeOffset left, System.DateTimeOffset right) { return default(bool); }
        public static bool operator >(System.DateTimeOffset left, System.DateTimeOffset right) { return default(bool); }
        public static bool operator >=(System.DateTimeOffset left, System.DateTimeOffset right) { return default(bool); }
        public static implicit operator System.DateTimeOffset (System.DateTime dateTime) { return default(System.DateTimeOffset); }
        public static bool operator !=(System.DateTimeOffset left, System.DateTimeOffset right) { return default(bool); }
        public static bool operator <(System.DateTimeOffset left, System.DateTimeOffset right) { return default(bool); }
        public static bool operator <=(System.DateTimeOffset left, System.DateTimeOffset right) { return default(bool); }
        public static System.TimeSpan operator -(System.DateTimeOffset left, System.DateTimeOffset right) { return default(System.TimeSpan); }
        public static System.DateTimeOffset operator -(System.DateTimeOffset dateTimeOffset, System.TimeSpan timeSpan) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset Parse(string input) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset Parse(string input, System.IFormatProvider formatProvider) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset Parse(string input, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset ParseExact(string input, string format, System.IFormatProvider formatProvider) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset ParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) { return default(System.DateTimeOffset); }
        public static System.DateTimeOffset ParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) { return default(System.DateTimeOffset); }
        public System.TimeSpan Subtract(System.DateTimeOffset value) { return default(System.TimeSpan); }
        public System.DateTimeOffset Subtract(System.TimeSpan value) { return default(System.DateTimeOffset); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public long ToFileTime() { return default(long); }
        public System.DateTimeOffset ToLocalTime() { return default(System.DateTimeOffset); }
        public System.DateTimeOffset ToOffset(System.TimeSpan offset) { return default(System.DateTimeOffset); }
        public override string ToString() { return default(string); }
        public string ToString(System.IFormatProvider formatProvider) { return default(string); }
        public string ToString(string format) { return default(string); }
        public string ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
        public System.DateTimeOffset ToUniversalTime() { return default(System.DateTimeOffset); }
        public long ToUnixTimeMilliseconds() { return default(long); }
        public long ToUnixTimeSeconds() { return default(long); }
        public static bool TryParse(string input, out System.DateTimeOffset result) { result = default(System.DateTimeOffset); return default(bool); }
        public static bool TryParse(string input, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { result = default(System.DateTimeOffset); return default(bool); }
        public static bool TryParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { result = default(System.DateTimeOffset); return default(bool); }
        public static bool TryParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { result = default(System.DateTimeOffset); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DayOfWeek
    {
        Friday = 5,
        Monday = 1,
        Saturday = 6,
        Sunday = 0,
        Thursday = 4,
        Tuesday = 2,
        Wednesday = 3,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DBNull : System.IConvertible
    {
        internal DBNull() { }
        public static readonly System.DBNull Value;
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        public override string ToString() { return default(string); }
        public string ToString(System.IFormatProvider provider) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Decimal : System.IComparable, System.IComparable<decimal>, System.IConvertible, System.IEquatable<decimal>, System.IFormattable
    {
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)0, (uint)4294967295, (uint)4294967295, (uint)4294967295)]
        public static readonly decimal MaxValue;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)128, (uint)0, (uint)0, (uint)1)]
        public static readonly decimal MinusOne;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)128, (uint)4294967295, (uint)4294967295, (uint)4294967295)]
        public static readonly decimal MinValue;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)0, (uint)0, (uint)0, (uint)1)]
        public static readonly decimal One;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)0, (uint)0, (uint)0, (uint)0)]
        public static readonly decimal Zero;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public Decimal(double value) { throw new System.NotImplementedException(); }
        public Decimal(int value) { throw new System.NotImplementedException(); }
        public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) { throw new System.NotImplementedException(); }
        public Decimal(int[] bits) { throw new System.NotImplementedException(); }
        public Decimal(long value) { throw new System.NotImplementedException(); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public Decimal(float value) { throw new System.NotImplementedException(); }
        [System.CLSCompliantAttribute(false)]
        public Decimal(uint value) { throw new System.NotImplementedException(); }
        [System.CLSCompliantAttribute(false)]
        public Decimal(ulong value) { throw new System.NotImplementedException(); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal Add(decimal d1, decimal d2) { return default(decimal); }
        public static decimal Ceiling(decimal d) { return default(decimal); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static int Compare(decimal d1, decimal d2) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public int CompareTo(decimal value) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public int CompareTo(object value) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal Divide(decimal d1, decimal d2) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Equals(decimal value) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool Equals(decimal d1, decimal d2) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object value) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal Floor(decimal d) { return default(decimal); }
        public static int[] GetBits(decimal d) { return default(int[]); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal Multiply(decimal d1, decimal d2) { return default(decimal); }
        public static decimal Negate(decimal d) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal operator +(decimal d1, decimal d2) { return default(decimal); }
        public static decimal operator --(decimal d) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal operator /(decimal d1, decimal d2) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator ==(decimal d1, decimal d2) { return default(bool); }
        public static explicit operator byte (decimal value) { return default(byte); }
        public static explicit operator char (decimal value) { return default(char); }
        public static explicit operator double (decimal value) { return default(double); }
        public static explicit operator short (decimal value) { return default(short); }
        public static explicit operator int (decimal value) { return default(int); }
        public static explicit operator long (decimal value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator sbyte (decimal value) { return default(sbyte); }
        public static explicit operator float (decimal value) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ushort (decimal value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator uint (decimal value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ulong (decimal value) { return default(ulong); }
        public static explicit operator decimal (double value) { return default(decimal); }
        public static explicit operator decimal (float value) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator >(decimal d1, decimal d2) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator >=(decimal d1, decimal d2) { return default(bool); }
        public static implicit operator decimal (byte value) { return default(decimal); }
        public static implicit operator decimal (char value) { return default(decimal); }
        public static implicit operator decimal (short value) { return default(decimal); }
        public static implicit operator decimal (int value) { return default(decimal); }
        public static implicit operator decimal (long value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator decimal (sbyte value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator decimal (ushort value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator decimal (uint value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator decimal (ulong value) { return default(decimal); }
        public static decimal operator ++(decimal d) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator !=(decimal d1, decimal d2) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator <(decimal d1, decimal d2) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator <=(decimal d1, decimal d2) { return default(bool); }
        public static decimal operator %(decimal d1, decimal d2) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal operator *(decimal d1, decimal d2) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal operator -(decimal d1, decimal d2) { return default(decimal); }
        public static decimal operator -(decimal d) { return default(decimal); }
        public static decimal operator +(decimal d) { return default(decimal); }
        public static decimal Parse(string s) { return default(decimal); }
        public static decimal Parse(string s, System.Globalization.NumberStyles style) { return default(decimal); }
        public static decimal Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(decimal); }
        public static decimal Parse(string s, System.IFormatProvider provider) { return default(decimal); }
        public static decimal Remainder(decimal d1, decimal d2) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal Round(decimal d, int decimals) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal Subtract(decimal d1, decimal d2) { return default(decimal); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        public static byte ToByte(decimal value) { return default(byte); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double ToDouble(decimal d) { return default(double); }
        public static short ToInt16(decimal value) { return default(short); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int ToInt32(decimal d) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static long ToInt64(decimal d) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(decimal value) { return default(sbyte); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static float ToSingle(decimal d) { return default(float); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(decimal value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static uint ToUInt32(decimal d) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static ulong ToUInt64(decimal d) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static decimal Truncate(decimal d) { return default(decimal); }
        public static bool TryParse(string s, out decimal result) { result = default(decimal); return default(bool); }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out decimal result) { result = default(decimal); return default(bool); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(2))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Delegate
    {
        [System.Security.SecuritySafeCriticalAttribute]
        protected Delegate(object target, string method) { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected Delegate(System.Type target, string method) { }
        public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } }
        public object Target { get { return default(object); } }
        public static System.Delegate Combine(System.Delegate a, System.Delegate b) { return default(System.Delegate); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static System.Delegate Combine(params System.Delegate[] delegates) { return default(System.Delegate); }
        protected virtual System.Delegate CombineImpl(System.Delegate d) { return default(System.Delegate); }
        public static System.Delegate CreateDelegate(System.Type type, object firstArgument, System.Reflection.MethodInfo method) { return default(System.Delegate); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Delegate CreateDelegate(System.Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) { return default(System.Delegate); }
        public static System.Delegate CreateDelegate(System.Type type, object target, string method) { return default(System.Delegate); }
        public static System.Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase) { return default(System.Delegate); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { return default(System.Delegate); }
        public static System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method) { return default(System.Delegate); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) { return default(System.Delegate); }
        public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method) { return default(System.Delegate); }
        public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method, bool ignoreCase) { return default(System.Delegate); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method, bool ignoreCase, bool throwOnBindFailure) { return default(System.Delegate); }
        public object DynamicInvoke(params object[] args) { return default(object); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public virtual System.Delegate[] GetInvocationList() { return default(System.Delegate[]); }
        public static bool operator ==(System.Delegate d1, System.Delegate d2) { return default(bool); }
        public static bool operator !=(System.Delegate d1, System.Delegate d2) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Delegate Remove(System.Delegate source, System.Delegate value) { return default(System.Delegate); }
        public static System.Delegate RemoveAll(System.Delegate source, System.Delegate value) { return default(System.Delegate); }
        protected virtual System.Delegate RemoveImpl(System.Delegate d) { return default(System.Delegate); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DivideByZeroException : System.ArithmeticException
    {
        public DivideByZeroException() { }
        public DivideByZeroException(string message) { }
        public DivideByZeroException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DllNotFoundException : System.TypeLoadException
    {
        public DllNotFoundException() { }
        public DllNotFoundException(string message) { }
        public DllNotFoundException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Double : System.IComparable, System.IComparable<double>, System.IConvertible, System.IEquatable<double>, System.IFormattable
    {
        public const double Epsilon = 4.94065645841247E-324;
        public const double MaxValue = 1.7976931348623157E+308;
        public const double MinValue = -1.7976931348623157E+308;
        public const double NaN = 0.0 / 0.0;
        public const double NegativeInfinity = -1.0 / 0.0;
        public const double PositiveInfinity = 1.0 / 0.0;
        public int CompareTo(double value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        public bool Equals(double obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsInfinity(double d) { return default(bool); }
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsNaN(double d) { return default(bool); }
        
        public static bool IsNegativeInfinity(double d) { return default(bool); }
        
        public static bool IsPositiveInfinity(double d) { return default(bool); }
        
        public static bool operator ==(double left, double right) { return default(bool); }
        
        public static bool operator >(double left, double right) { return default(bool); }
        
        public static bool operator >=(double left, double right) { return default(bool); }
        
        public static bool operator !=(double left, double right) { return default(bool); }
        
        public static bool operator <(double left, double right) { return default(bool); }
        
        public static bool operator <=(double left, double right) { return default(bool); }
        public static double Parse(string s) { return default(double); }
        public static double Parse(string s, System.Globalization.NumberStyles style) { return default(double); }
        public static double Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(double); }
        public static double Parse(string s, System.IFormatProvider provider) { return default(double); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string s, out double result) { result = default(double); return default(bool); }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out double result) { result = default(double); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EntryPointNotFoundException : System.TypeLoadException
    {
        public EntryPointNotFoundException() { }
        public EntryPointNotFoundException(string message) { }
        public EntryPointNotFoundException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Enum : System.ValueType, System.IComparable, System.IConvertible, System.IFormattable
    {
        protected Enum() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public int CompareTo(object target) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static string Format(System.Type enumType, object value, string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static string GetName(System.Type enumType, object value) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static string[] GetNames(System.Type enumType) { return default(string[]); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static System.Type GetUnderlyingType(System.Type enumType) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static System.Array GetValues(System.Type enumType) { return default(System.Array); }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool HasFlag(System.Enum flag) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static bool IsDefined(System.Type enumType, object value) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object Parse(System.Type enumType, string value) { return default(object); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object Parse(System.Type enumType, string value, bool ignoreCase) { return default(object); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object ToObject(System.Type enumType, object value) { return default(object); }
        public override string ToString() { return default(string); }
        [System.ObsoleteAttribute("The provider argument is not used. Please use ToString().")]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        public string ToString(string format) { return default(string); }
        [System.ObsoleteAttribute("The provider argument is not used. Please use ToString(String).")]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct { result = default(TEnum); return default(bool); }
        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct { result = default(TEnum); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class Environment
    {
        public static int CurrentManagedThreadId { get { return default(int); } }
        public static int ExitCode { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(int); } [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]set { } }
        public static bool HasShutdownStarted { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(bool); } }
        public static string MachineName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public static string NewLine { get { return default(string); } }
        public static System.OperatingSystem OSVersion { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.OperatingSystem); } }
        public static int ProcessorCount { [System.Security.SecuritySafeCriticalAttribute]get { return default(int); } }
        public static string StackTrace { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public static int TickCount { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(int); } }
        public static System.Version Version { get { return default(System.Version); } }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public static void Exit(int exitCode) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string ExpandEnvironmentVariables(string name) { return default(string); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static void FailFast(string message) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static void FailFast(string message, System.Exception exception) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string[] GetCommandLineArgs() { return default(string[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string GetEnvironmentVariable(string variable) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Collections.IDictionary GetEnvironmentVariables() { return default(System.Collections.IDictionary); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void SetEnvironmentVariable(string variable, string value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EventArgs
    {
        public static readonly System.EventArgs Empty;
        public EventArgs() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void EventHandler(object sender, System.EventArgs e);
    public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Exception
    {
        public Exception() { }
        public Exception(string message) { }
        public Exception(string message, System.Exception innerException) { }
        public virtual System.Collections.IDictionary Data { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Collections.IDictionary); } }
        public virtual string HelpLink { get { return default(string); } set { } }
        public int HResult { get { return default(int); } protected set { } }
        public System.Exception InnerException { get { return default(System.Exception); } }
        public virtual string Message { get { return default(string); } }
        public virtual string Source { [System.Security.SecurityCriticalAttribute]get { return default(string); } [System.Security.SecurityCriticalAttribute]set { } }
        public virtual string StackTrace { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual System.Exception GetBaseException() { return default(System.Exception); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
    }
    [System.ObsoleteAttribute("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ExecutionEngineException : System.SystemException
    {
        internal ExecutionEngineException() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FieldAccessException : System.MemberAccessException
    {
        public FieldAccessException() { }
        public FieldAccessException(string message) { }
        public FieldAccessException(string message, System.Exception inner) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(16), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FlagsAttribute : System.Attribute
    {
        public FlagsAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FormatException : System.SystemException
    {
        public FormatException() { }
        public FormatException(string message) { }
        public FormatException(string message, System.Exception innerException) { }
    }
    public abstract partial class FormattableString : System.IFormattable
    {
        protected FormattableString() { }
        public abstract int ArgumentCount { get; }
        public abstract string Format { get; }
        public abstract object GetArgument(int index);
        public abstract object[] GetArguments();
        public static string Invariant(System.FormattableString formattable) { return default(string); }
        string System.IFormattable.ToString(string ignored, System.IFormatProvider formatProvider) { return default(string); }
        public override string ToString() { return default(string); }
        public abstract string ToString(System.IFormatProvider formatProvider);
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate TResult Func<out TResult>();
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate TResult Func<in T, out TResult>(T arg);
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public delegate TResult Func<in T1, in T2, in T3, in T4, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
    public static partial class GC
    {
        public static int MaxGeneration { [System.Security.SecuritySafeCriticalAttribute]get { return default(int); } }
        [System.Security.SecurityCriticalAttribute]
        public static void AddMemoryPressure(long bytesAllocated) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Collect() { }
        public static void Collect(int generation) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Collect(int generation, System.GCCollectionMode mode) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Collect(int generation, System.GCCollectionMode mode, bool blocking) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Collect(int generation, System.GCCollectionMode mode, bool blocking, bool compacting) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static int CollectionCount(int generation) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static int GetGeneration(object obj) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static long GetTotalMemory(bool forceFullCollection) { return default(long); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void KeepAlive(object obj) { }
        [System.Security.SecurityCriticalAttribute]
        public static void RemoveMemoryPressure(long bytesAllocated) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void ReRegisterForFinalize(object obj) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void SuppressFinalize(object obj) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void WaitForPendingFinalizers() { }
    }
    public enum GCCollectionMode
    {
        Default = 0,
        Forced = 1,
        Optimized = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Guid : System.IComparable, System.IComparable<System.Guid>, System.IEquatable<System.Guid>, System.IFormattable
    {
        public static readonly System.Guid Empty;
        public Guid(byte[] b) { throw new System.NotImplementedException(); }
        public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { throw new System.NotImplementedException(); }
        public Guid(int a, short b, short c, byte[] d) { throw new System.NotImplementedException(); }
        public Guid(string g) { throw new System.NotImplementedException(); }
        [System.CLSCompliantAttribute(false)]
        public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { throw new System.NotImplementedException(); }
        public int CompareTo(System.Guid value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        public bool Equals(System.Guid g) { return default(bool); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Guid NewGuid() { return default(System.Guid); }
        public static bool operator ==(System.Guid a, System.Guid b) { return default(bool); }
        public static bool operator !=(System.Guid a, System.Guid b) { return default(bool); }
        public static System.Guid Parse(string input) { return default(System.Guid); }
        public static System.Guid ParseExact(string input, string format) { return default(System.Guid); }
        public byte[] ToByteArray() { return default(byte[]); }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string input, out System.Guid result) { result = default(System.Guid); return default(bool); }
        public static bool TryParseExact(string input, string format, out System.Guid result) { result = default(System.Guid); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IAsyncResult
    {
        object AsyncState { get; }
        System.Threading.WaitHandle AsyncWaitHandle { get; }
        bool CompletedSynchronously { get; }
        bool IsCompleted { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IComparable
    {
        int CompareTo(object obj);
    }
    public partial interface IComparable<in T>
    {
        int CompareTo(T other);
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IConvertible
    {
        System.TypeCode GetTypeCode();
        bool ToBoolean(System.IFormatProvider provider);
        byte ToByte(System.IFormatProvider provider);
        char ToChar(System.IFormatProvider provider);
        System.DateTime ToDateTime(System.IFormatProvider provider);
        decimal ToDecimal(System.IFormatProvider provider);
        double ToDouble(System.IFormatProvider provider);
        short ToInt16(System.IFormatProvider provider);
        int ToInt32(System.IFormatProvider provider);
        long ToInt64(System.IFormatProvider provider);
        sbyte ToSByte(System.IFormatProvider provider);
        float ToSingle(System.IFormatProvider provider);
        string ToString(System.IFormatProvider provider);
        object ToType(System.Type conversionType, System.IFormatProvider provider);
        ushort ToUInt16(System.IFormatProvider provider);
        uint ToUInt32(System.IFormatProvider provider);
        ulong ToUInt64(System.IFormatProvider provider);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ICustomFormatter
    {
        string Format(string format, object arg, System.IFormatProvider formatProvider);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IDisposable
    {
        void Dispose();
    }
    public partial interface IEquatable<T>
    {
        bool Equals(T other);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IFormatProvider
    {
        object GetFormat(System.Type formatType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IFormattable
    {
        string ToString(string format, System.IFormatProvider formatProvider);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IndexOutOfRangeException : System.SystemException
    {
        public IndexOutOfRangeException() { }
        public IndexOutOfRangeException(string message) { }
        public IndexOutOfRangeException(string message, System.Exception innerException) { }
    }
    public sealed partial class InsufficientExecutionStackException : System.SystemException
    {
        public InsufficientExecutionStackException() { }
        public InsufficientExecutionStackException(string message) { }
        public InsufficientExecutionStackException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Int16 : System.IComparable, System.IComparable<short>, System.IConvertible, System.IEquatable<short>, System.IFormattable
    {
        public const short MaxValue = (short)32767;
        public const short MinValue = (short)-32768;
        public int CompareTo(short value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        
        public bool Equals(short obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public static short Parse(string s) { return default(short); }
        public static short Parse(string s, System.Globalization.NumberStyles style) { return default(short); }
        public static short Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(short); }
        public static short Parse(string s, System.IFormatProvider provider) { return default(short); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        public string ToString(string format) { return default(string); }
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out short result) { result = default(short); return default(bool); }
        public static bool TryParse(string s, out short result) { result = default(short); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Int32 : System.IComparable, System.IComparable<int>, System.IConvertible, System.IEquatable<int>, System.IFormattable
    {
        public const int MaxValue = 2147483647;
        public const int MinValue = -2147483648;
        public int CompareTo(int value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        
        public bool Equals(int obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public static int Parse(string s) { return default(int); }
        public static int Parse(string s, System.Globalization.NumberStyles style) { return default(int); }
        public static int Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(int); }
        public static int Parse(string s, System.IFormatProvider provider) { return default(int); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out int result) { result = default(int); return default(bool); }
        public static bool TryParse(string s, out int result) { result = default(int); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Int64 : System.IComparable, System.IComparable<long>, System.IConvertible, System.IEquatable<long>, System.IFormattable
    {
        public const long MaxValue = (long)9223372036854775807;
        public const long MinValue = (long)-9223372036854775808;
        public int CompareTo(long value) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        
        public bool Equals(long obj) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public static long Parse(string s) { return default(long); }
        public static long Parse(string s, System.Globalization.NumberStyles style) { return default(long); }
        public static long Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(long); }
        public static long Parse(string s, System.IFormatProvider provider) { return default(long); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out long result) { result = default(long); return default(bool); }
        public static bool TryParse(string s, out long result) { result = default(long); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IntPtr
    {
        public static readonly System.IntPtr Zero;
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public IntPtr(int value) { throw new System.NotImplementedException(); }
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public IntPtr(long value) { throw new System.NotImplementedException(); }
        [System.CLSCompliantAttribute(false)]
        
        
        [System.Security.SecurityCriticalAttribute]
        public unsafe IntPtr(void* value) { throw new System.NotImplementedException(); }
        public static int Size { get { return default(int); } }
        
        
        public static System.IntPtr Add(System.IntPtr pointer, int offset) { return default(System.IntPtr); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        
        
        public static System.IntPtr operator +(System.IntPtr pointer, int offset) { return default(System.IntPtr); }
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator ==(System.IntPtr value1, System.IntPtr value2) { return default(bool); }
        
        
        public static explicit operator System.IntPtr (int value) { return default(System.IntPtr); }
        
        
        public static explicit operator System.IntPtr (long value) { return default(System.IntPtr); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static explicit operator int (System.IntPtr value) { return default(int); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static explicit operator long (System.IntPtr value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        
        [System.Security.SecuritySafeCriticalAttribute]
        public unsafe static explicit operator void* (System.IntPtr value) { return default(void*); }
        [System.CLSCompliantAttribute(false)]
        
        
        [System.Security.SecurityCriticalAttribute]
        public unsafe static explicit operator System.IntPtr (void* value) { return default(System.IntPtr); }
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator !=(System.IntPtr value1, System.IntPtr value2) { return default(bool); }
        
        
        public static System.IntPtr operator -(System.IntPtr pointer, int offset) { return default(System.IntPtr); }
        
        
        public static System.IntPtr Subtract(System.IntPtr pointer, int offset) { return default(System.IntPtr); }
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public int ToInt32() { return default(int); }
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public long ToInt64() { return default(long); }
        [System.CLSCompliantAttribute(false)]
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public unsafe void* ToPointer() { return default(void*); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InvalidCastException : System.SystemException
    {
        public InvalidCastException() { }
        public InvalidCastException(string message) { }
        public InvalidCastException(string message, System.Exception innerException) { }
        public InvalidCastException(string message, int errorCode) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InvalidOperationException : System.SystemException
    {
        public InvalidOperationException() { }
        public InvalidOperationException(string message) { }
        public InvalidOperationException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class InvalidProgramException : System.SystemException
    {
        public InvalidProgramException() { }
        public InvalidProgramException(string message) { }
        public InvalidProgramException(string message, System.Exception inner) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
    
    public partial class InvalidTimeZoneException : System.Exception
    {
        public InvalidTimeZoneException() { }
        public InvalidTimeZoneException(string message) { }
        public InvalidTimeZoneException(string message, System.Exception innerException) { }
    }
    public partial interface IObservable<out T>
    {
        System.IDisposable Subscribe(System.IObserver<T> observer);
    }
    public partial interface IObserver<in T>
    {
        void OnCompleted();
        void OnError(System.Exception error);
        void OnNext(T value);
    }
    public partial interface IProgress<in T>
    {
        void Report(T value);
    }
    public partial interface IServiceProvider
    {
        object GetService(System.Type serviceType);
    }
    [System.Diagnostics.DebuggerDisplayAttribute("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class Lazy<T>
    {
        public Lazy() { }
        public Lazy(bool isThreadSafe) { }
        public Lazy(System.Func<T> valueFactory) { }
        public Lazy(System.Func<T> valueFactory, bool isThreadSafe) { }
        public Lazy(System.Func<T> valueFactory, System.Threading.LazyThreadSafetyMode mode) { }
        public Lazy(System.Threading.LazyThreadSafetyMode mode) { }
        public bool IsValueCreated { get { return default(bool); } }
        [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
        public T Value { get { return default(T); } }
        public override string ToString() { return default(string); }
    }
    public static partial class Math
    {
        public const double E = 2.7182818284590451;
        public const double PI = 3.1415926535897931;
        public static decimal Abs(decimal value) { return default(decimal); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Abs(double value) { return default(double); }
        public static short Abs(short value) { return default(short); }
        public static int Abs(int value) { return default(int); }
        public static long Abs(long value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Abs(sbyte value) { return default(sbyte); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static float Abs(float value) { return default(float); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Acos(double d) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Asin(double d) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Atan(double d) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Atan2(double y, double x) { return default(double); }
        public static decimal Ceiling(decimal d) { return default(decimal); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Ceiling(double a) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Cos(double d) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Cosh(double value) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Exp(double d) { return default(double); }
        public static decimal Floor(decimal d) { return default(decimal); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Floor(double d) { return default(double); }
        public static double IEEERemainder(double x, double y) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Log(double d) { return default(double); }
        public static double Log(double a, double newBase) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Log10(double d) { return default(double); }
        
        
        public static byte Max(byte val1, byte val2) { return default(byte); }
        
        public static decimal Max(decimal val1, decimal val2) { return default(decimal); }
        
        public static double Max(double val1, double val2) { return default(double); }
        
        
        public static short Max(short val1, short val2) { return default(short); }
        
        
        public static int Max(int val1, int val2) { return default(int); }
        
        
        public static long Max(long val1, long val2) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static sbyte Max(sbyte val1, sbyte val2) { return default(sbyte); }
        
        public static float Max(float val1, float val2) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static ushort Max(ushort val1, ushort val2) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static uint Max(uint val1, uint val2) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static ulong Max(ulong val1, ulong val2) { return default(ulong); }
        
        
        public static byte Min(byte val1, byte val2) { return default(byte); }
        
        public static decimal Min(decimal val1, decimal val2) { return default(decimal); }
        
        public static double Min(double val1, double val2) { return default(double); }
        
        
        public static short Min(short val1, short val2) { return default(short); }
        
        
        public static int Min(int val1, int val2) { return default(int); }
        
        
        public static long Min(long val1, long val2) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static sbyte Min(sbyte val1, sbyte val2) { return default(sbyte); }
        
        public static float Min(float val1, float val2) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static ushort Min(ushort val1, ushort val2) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static uint Min(uint val1, uint val2) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        
        
        public static ulong Min(ulong val1, ulong val2) { return default(ulong); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Pow(double x, double y) { return default(double); }
        public static decimal Round(decimal d) { return default(decimal); }
        public static decimal Round(decimal d, int decimals) { return default(decimal); }
        public static decimal Round(decimal d, int decimals, System.MidpointRounding mode) { return default(decimal); }
        public static decimal Round(decimal d, System.MidpointRounding mode) { return default(decimal); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Round(double a) { return default(double); }
        public static double Round(double value, int digits) { return default(double); }
        public static double Round(double value, int digits, System.MidpointRounding mode) { return default(double); }
        public static double Round(double value, System.MidpointRounding mode) { return default(double); }
        public static int Sign(decimal value) { return default(int); }
        public static int Sign(double value) { return default(int); }
        public static int Sign(short value) { return default(int); }
        public static int Sign(int value) { return default(int); }
        public static int Sign(long value) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int Sign(sbyte value) { return default(int); }
        public static int Sign(float value) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Sin(double a) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Sinh(double value) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static double Sqrt(double d) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Tan(double a) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Tanh(double value) { return default(double); }
        public static decimal Truncate(decimal d) { return default(decimal); }
        public static double Truncate(double d) { return default(double); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MemberAccessException : System.SystemException
    {
        public MemberAccessException() { }
        public MemberAccessException(string message) { }
        public MemberAccessException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodAccessException : System.MemberAccessException
    {
        public MethodAccessException() { }
        public MethodAccessException(string message) { }
        public MethodAccessException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum MidpointRounding
    {
        AwayFromZero = 1,
        ToEven = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MissingFieldException : System.MissingMemberException
    {
        public MissingFieldException() { }
        public MissingFieldException(string message) { }
        public MissingFieldException(string message, System.Exception inner) { }
        public override string Message { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MissingMemberException : System.MemberAccessException
    {
        public MissingMemberException() { }
        public MissingMemberException(string message) { }
        public MissingMemberException(string message, System.Exception inner) { }
        public override string Message { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MissingMethodException : System.MissingMemberException
    {
        public MissingMethodException() { }
        public MissingMethodException(string message) { }
        public MissingMethodException(string message, System.Exception inner) { }
        public override string Message { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class MTAThreadAttribute : System.Attribute
    {
        public MTAThreadAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class MulticastDelegate : System.Delegate
    {
        protected MulticastDelegate(object target, string method) : base (default(object), default(string)) { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected sealed override System.Delegate CombineImpl(System.Delegate follow) { return default(System.Delegate); }
        [System.Security.SecuritySafeCriticalAttribute]
        public sealed override bool Equals(object obj) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public sealed override int GetHashCode() { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public sealed override System.Delegate[] GetInvocationList() { return default(System.Delegate[]); }
        public static bool operator ==(System.MulticastDelegate d1, System.MulticastDelegate d2) { return default(bool); }
        public static bool operator !=(System.MulticastDelegate d1, System.MulticastDelegate d2) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        protected sealed override System.Delegate RemoveImpl(System.Delegate value) { return default(System.Delegate); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class MulticastNotSupportedException : System.SystemException
    {
        public MulticastNotSupportedException() { }
        public MulticastNotSupportedException(string message) { }
        public MulticastNotSupportedException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class NotFiniteNumberException : System.ArithmeticException
    {
        public NotFiniteNumberException() { }
        public NotFiniteNumberException(string message) { }
        public NotFiniteNumberException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class NotImplementedException : System.SystemException
    {
        public NotImplementedException() { }
        public NotImplementedException(string message) { }
        public NotImplementedException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class NotSupportedException : System.SystemException
    {
        public NotSupportedException() { }
        public NotSupportedException(string message) { }
        public NotSupportedException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class Nullable
    {
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static int Compare<T>(System.Nullable<T> n1, System.Nullable<T> n2) where T : struct { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static bool Equals<T>(System.Nullable<T> n1, System.Nullable<T> n2) where T : struct { return default(bool); }
        public static System.Type GetUnderlyingType(System.Type nullableType) { return default(System.Type); }
    }
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Nullable<T> where T : struct
    {
        
        public Nullable(T value) { throw new System.NotImplementedException(); }
        public bool HasValue { get { return default(bool); } }
        public T Value { get { return default(T); } }
        public override bool Equals(object other) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        
        public T GetValueOrDefault() { return default(T); }
        
        public T GetValueOrDefault(T defaultValue) { return default(T); }
        
        public static explicit operator T (System.Nullable<T> value) { return default(T); }
        
        public static implicit operator System.Nullable<T> (T value) { return default(System.Nullable<T>); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class NullReferenceException : System.SystemException
    {
        public NullReferenceException() { }
        public NullReferenceException(string message) { }
        public NullReferenceException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(2))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Object
    {
        
        
        public Object() { }
        public virtual bool Equals(object obj) { return default(bool); }
        public static bool Equals(object objA, object objB) { return default(bool); }
        ~Object() { }
        public virtual int GetHashCode() { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public System.Type GetType() { return default(System.Type); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        protected object MemberwiseClone() { return default(object); }
        
        
        public static bool ReferenceEquals(object objA, object objB) { return default(bool); }
        public virtual string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ObjectDisposedException : System.InvalidOperationException
    {
        public ObjectDisposedException(string objectName) { }
        public ObjectDisposedException(string message, System.Exception innerException) { }
        public ObjectDisposedException(string objectName, string message) { }
        public override string Message { get { return default(string); } }
        public string ObjectName { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(6140), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ObsoleteAttribute : System.Attribute
    {
        public ObsoleteAttribute() { }
        public ObsoleteAttribute(string message) { }
        public ObsoleteAttribute(string message, bool error) { }
        public bool IsError { get { return default(bool); } }
        public string Message { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OperatingSystem
    {
        public OperatingSystem(System.PlatformID platform, System.Version version) { }
        public System.PlatformID Platform { get { return default(System.PlatformID); } }
        public System.Version Version { get { return default(System.Version); } }
        public object Clone() { return default(object); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OperationCanceledException : System.SystemException
    {
        public OperationCanceledException() { }
        public OperationCanceledException(string message) { }
        public OperationCanceledException(string message, System.Exception innerException) { }
        public OperationCanceledException(string message, System.Exception innerException, System.Threading.CancellationToken token) { }
        public OperationCanceledException(string message, System.Threading.CancellationToken token) { }
        public OperationCanceledException(System.Threading.CancellationToken token) { }
        public System.Threading.CancellationToken CancellationToken { get { return default(System.Threading.CancellationToken); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OutOfMemoryException : System.SystemException
    {
        public OutOfMemoryException() { }
        public OutOfMemoryException(string message) { }
        public OutOfMemoryException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OverflowException : System.ArithmeticException
    {
        public OverflowException() { }
        public OverflowException(string message) { }
        public OverflowException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=true, AllowMultiple=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ParamArrayAttribute : System.Attribute
    {
        public ParamArrayAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PlatformID
    {
        MacOSX = 6,
        Unix = 4,
        Win32NT = 2,
        Win32S = 0,
        Win32Windows = 1,
        WinCE = 3,
        Xbox = 5,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PlatformNotSupportedException : System.NotSupportedException
    {
        public PlatformNotSupportedException() { }
        public PlatformNotSupportedException(string message) { }
        public PlatformNotSupportedException(string message, System.Exception inner) { }
    }
    public delegate bool Predicate<in T>(T obj);
    public partial class Progress<T> : System.IProgress<T>
    {
        public Progress() { }
        public Progress(System.Action<T> handler) { }
        public event System.EventHandler<T> ProgressChanged { add { } remove { } }
        protected virtual void OnReport(T value) { }
        void System.IProgress<T>.Report(T value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Random
    {
        public Random() { }
        public Random(int Seed) { }
        public virtual int Next() { return default(int); }
        public virtual int Next(int maxValue) { return default(int); }
        public virtual int Next(int minValue, int maxValue) { return default(int); }
        public virtual void NextBytes(byte[] buffer) { }
        public virtual double NextDouble() { return default(double); }
        protected virtual double Sample() { return default(double); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RankException : System.SystemException
    {
        public RankException() { }
        public RankException(string message) { }
        public RankException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RuntimeArgumentHandle
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RuntimeFieldHandle
    {
        
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Equals(System.RuntimeFieldHandle handle) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.RuntimeFieldHandle left, System.RuntimeFieldHandle right) { return default(bool); }
        public static bool operator !=(System.RuntimeFieldHandle left, System.RuntimeFieldHandle right) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RuntimeMethodHandle
    {
        public System.IntPtr Value { [System.Security.SecurityCriticalAttribute]get { return default(System.IntPtr); } }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Equals(System.RuntimeMethodHandle handle) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.RuntimeMethodHandle left, System.RuntimeMethodHandle right) { return default(bool); }
        public static bool operator !=(System.RuntimeMethodHandle left, System.RuntimeMethodHandle right) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RuntimeTypeHandle
    {
        public System.IntPtr Value { [System.Security.SecurityCriticalAttribute]get { return default(System.IntPtr); } }
        
        public override bool Equals(object obj) { return default(bool); }
        
        public bool Equals(System.RuntimeTypeHandle handle) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(object left, System.RuntimeTypeHandle right) { return default(bool); }
        public static bool operator ==(System.RuntimeTypeHandle left, object right) { return default(bool); }
        public static bool operator !=(object left, System.RuntimeTypeHandle right) { return default(bool); }
        public static bool operator !=(System.RuntimeTypeHandle left, object right) { return default(bool); }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SByte : System.IComparable, System.IComparable<sbyte>, System.IConvertible, System.IEquatable<sbyte>, System.IFormattable
    {
        public const sbyte MaxValue = (sbyte)127;
        public const sbyte MinValue = (sbyte)-128;
        public int CompareTo(object obj) { return default(int); }
        public int CompareTo(sbyte value) { return default(int); }
        public override bool Equals(object obj) { return default(bool); }
        
        public bool Equals(sbyte obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Parse(string s) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Parse(string s, System.Globalization.NumberStyles style) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Parse(string s, System.IFormatProvider provider) { return default(sbyte); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        public string ToString(string format) { return default(string); }
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out sbyte result) { result = default(sbyte); return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out sbyte result) { result = default(sbyte); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Single : System.IComparable, System.IComparable<float>, System.IConvertible, System.IEquatable<float>, System.IFormattable
    {
        public const float Epsilon = 1.401298E-45f;
        public const float MaxValue = 3.40282347E+38f;
        public const float MinValue = -3.40282347E+38f;
        public const float NaN = 0.0f / 0.0f;
        public const float NegativeInfinity = -1.0f / 0.0f;
        public const float PositiveInfinity = 1.0f / 0.0f;
        public int CompareTo(object value) { return default(int); }
        public int CompareTo(float value) { return default(int); }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(float obj) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsInfinity(float f) { return default(bool); }
        
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsNaN(float f) { return default(bool); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsNegativeInfinity(float f) { return default(bool); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsPositiveInfinity(float f) { return default(bool); }
        
        public static bool operator ==(float left, float right) { return default(bool); }
        
        public static bool operator >(float left, float right) { return default(bool); }
        
        public static bool operator >=(float left, float right) { return default(bool); }
        
        public static bool operator !=(float left, float right) { return default(bool); }
        
        public static bool operator <(float left, float right) { return default(bool); }
        
        public static bool operator <=(float left, float right) { return default(bool); }
        public static float Parse(string s) { return default(float); }
        public static float Parse(string s, System.Globalization.NumberStyles style) { return default(float); }
        public static float Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(float); }
        public static float Parse(string s, System.IFormatProvider provider) { return default(float); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out float result) { result = default(float); return default(bool); }
        public static bool TryParse(string s, out float result) { result = default(float); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StackOverflowException : System.SystemException
    {
        public StackOverflowException() { }
        public StackOverflowException(string message) { }
        public StackOverflowException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class STAThreadAttribute : System.Attribute
    {
        public STAThreadAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class String : System.Collections.Generic.IEnumerable<char>, System.Collections.IEnumerable, System.IComparable, System.IComparable<string>, System.IConvertible, System.IEquatable<string>
    {
        public static readonly string Empty;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe String(char* value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe String(char* value, int startIndex, int length) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public String(char c, int count) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public String(char[] value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public String(char[] value, int startIndex, int length) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe String(sbyte* value) { }
        [System.Runtime.CompilerServices.IndexerName("Chars")]
        public char this[int index] { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(char); } }
        public int Length { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(int); } }
        public static int Compare(string strA, int indexA, string strB, int indexB, int length) { return default(int); }
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, System.StringComparison comparisonType) { return default(int); }
        public static int Compare(string strA, string strB) { return default(int); }
        public static int Compare(string strA, string strB, bool ignoreCase) { return default(int); }
        public static int Compare(string strA, string strB, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int Compare(string strA, string strB, System.StringComparison comparisonType) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { return default(int); }
        public static int CompareOrdinal(string strA, string strB) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        public int CompareTo(string strB) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static string Concat(System.Collections.Generic.IEnumerable<string> values) { return default(string); }
        public static string Concat(object arg0) { return default(string); }
        public static string Concat(object arg0, object arg1) { return default(string); }
        public static string Concat(object arg0, object arg1, object arg2) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Concat(params object[] args) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Concat(string str0, string str1) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Concat(string str0, string str1, string str2) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Concat(string str0, string str1, string str2, string str3) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Concat(params string[] values) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static string Concat<T>(System.Collections.Generic.IEnumerable<T> values) { return default(string); }
        public bool Contains(string value) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Copy(string str) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }
        public bool EndsWith(string value) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public bool EndsWith(string value, System.StringComparison comparisonType) { return default(bool); }
        
        public override bool Equals(object obj) { return default(bool); }
        
        public bool Equals(string value) { return default(bool); }
        public static bool Equals(string a, string b) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool Equals(string a, string b, System.StringComparison comparisonType) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Equals(string value, System.StringComparison comparisonType) { return default(bool); }
        public static string Format(System.IFormatProvider provider, string format, object arg0) { return default(string); }
        public static string Format(System.IFormatProvider provider, string format, object arg0, object arg1) { return default(string); }
        public static string Format(System.IFormatProvider provider, string format, object arg0, object arg1, object arg2) { return default(string); }
        public static string Format(System.IFormatProvider provider, string format, params object[] args) { return default(string); }
        public static string Format(string format, object arg0) { return default(string); }
        public static string Format(string format, object arg0, object arg1) { return default(string); }
        public static string Format(string format, object arg0, object arg1, object arg2) { return default(string); }
        public static string Format(string format, params object[] args) { return default(string); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        public int IndexOf(char value) { return default(int); }
        public int IndexOf(char value, int startIndex) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public int IndexOf(char value, int startIndex, int count) { return default(int); }
        public int IndexOf(string value) { return default(int); }
        public int IndexOf(string value, int startIndex) { return default(int); }
        public int IndexOf(string value, int startIndex, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public int IndexOf(string value, int startIndex, int count, System.StringComparison comparisonType) { return default(int); }
        public int IndexOf(string value, int startIndex, System.StringComparison comparisonType) { return default(int); }
        public int IndexOf(string value, System.StringComparison comparisonType) { return default(int); }
        public int IndexOfAny(char[] anyOf) { return default(int); }
        public int IndexOfAny(char[] anyOf, int startIndex) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public int IndexOfAny(char[] anyOf, int startIndex, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string Insert(int startIndex, string value) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Intern(string str) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string IsInterned(string str) { return default(string); }
        public static bool IsNullOrEmpty(string value) { return default(bool); }
        public static bool IsNullOrWhiteSpace(string value) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static string Join(string separator, System.Collections.Generic.IEnumerable<string> values) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static string Join(string separator, params object[] values) { return default(string); }
        public static string Join(string separator, params string[] value) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string Join(string separator, string[] value, int startIndex, int count) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static string Join<T>(string separator, System.Collections.Generic.IEnumerable<T> values) { return default(string); }
        public int LastIndexOf(char value) { return default(int); }
        public int LastIndexOf(char value, int startIndex) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public int LastIndexOf(char value, int startIndex, int count) { return default(int); }
        public int LastIndexOf(string value) { return default(int); }
        public int LastIndexOf(string value, int startIndex) { return default(int); }
        public int LastIndexOf(string value, int startIndex, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public int LastIndexOf(string value, int startIndex, int count, System.StringComparison comparisonType) { return default(int); }
        public int LastIndexOf(string value, int startIndex, System.StringComparison comparisonType) { return default(int); }
        public int LastIndexOf(string value, System.StringComparison comparisonType) { return default(int); }
        public int LastIndexOfAny(char[] anyOf) { return default(int); }
        public int LastIndexOfAny(char[] anyOf, int startIndex) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { return default(int); }
        public static bool operator ==(string a, string b) { return default(bool); }
        public static bool operator !=(string a, string b) { return default(bool); }
        public string PadLeft(int totalWidth) { return default(string); }
        public string PadLeft(int totalWidth, char paddingChar) { return default(string); }
        public string PadRight(int totalWidth) { return default(string); }
        public string PadRight(int totalWidth, char paddingChar) { return default(string); }
        public string Remove(int startIndex) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string Remove(int startIndex, int count) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string Replace(char oldChar, char newChar) { return default(string); }
        public string Replace(string oldValue, string newValue) { return default(string); }
        public string[] Split(params char[] separator) { return default(string[]); }
        public string[] Split(char[] separator, int count) { return default(string[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] Split(char[] separator, int count, System.StringSplitOptions options) { return default(string[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] Split(char[] separator, System.StringSplitOptions options) { return default(string[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] Split(string[] separator, int count, System.StringSplitOptions options) { return default(string[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] Split(string[] separator, System.StringSplitOptions options) { return default(string[]); }
        public bool StartsWith(string value) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public bool StartsWith(string value, System.StringComparison comparisonType) { return default(bool); }
        public string Substring(int startIndex) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string Substring(int startIndex, int length) { return default(string); }
        System.Collections.Generic.IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<char>); }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public char[] ToCharArray() { return default(char[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public char[] ToCharArray(int startIndex, int length) { return default(char[]); }
        public string ToLower() { return default(string); }
        public string ToLower(System.Globalization.CultureInfo culture) { return default(string); }
        public string ToLowerInvariant() { return default(string); }
        public override string ToString() { return default(string); }
        public string ToString(System.IFormatProvider provider) { return default(string); }
        public string ToUpper() { return default(string); }
        public string ToUpper(System.Globalization.CultureInfo culture) { return default(string); }
        public string ToUpperInvariant() { return default(string); }
        public string Trim() { return default(string); }
        public string Trim(params char[] trimChars) { return default(string); }
        public string TrimEnd(params char[] trimChars) { return default(string); }
        public string TrimStart(params char[] trimChars) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class StringComparer : System.Collections.Generic.IComparer<string>, System.Collections.Generic.IEqualityComparer<string>, System.Collections.IComparer, System.Collections.IEqualityComparer
    {
        protected StringComparer() { }
        public static System.StringComparer CurrentCulture { get { return default(System.StringComparer); } }
        public static System.StringComparer CurrentCultureIgnoreCase { get { return default(System.StringComparer); } }
        public static System.StringComparer InvariantCulture { get { return default(System.StringComparer); } }
        public static System.StringComparer InvariantCultureIgnoreCase { get { return default(System.StringComparer); } }
        public static System.StringComparer Ordinal { get { return default(System.StringComparer); } }
        public static System.StringComparer OrdinalIgnoreCase { get { return default(System.StringComparer); } }
        public int Compare(object x, object y) { return default(int); }
        public abstract int Compare(string x, string y);
        public static System.StringComparer Create(System.Globalization.CultureInfo culture, bool ignoreCase) { return default(System.StringComparer); }
        public new bool Equals(object x, object y) { return default(bool); }
        public abstract bool Equals(string x, string y);
        public int GetHashCode(object obj) { return default(int); }
        public abstract int GetHashCode(string obj);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum StringComparison
    {
        CurrentCulture = 0,
        CurrentCultureIgnoreCase = 1,
        InvariantCulture = 2,
        InvariantCultureIgnoreCase = 3,
        Ordinal = 4,
        OrdinalIgnoreCase = 5,
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public enum StringSplitOptions
    {
        None = 0,
        RemoveEmptyEntries = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SystemException : System.Exception
    {
        public SystemException() { }
        public SystemException(string message) { }
        public SystemException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ThreadStaticAttribute : System.Attribute
    {
        public ThreadStaticAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TimeoutException : System.SystemException
    {
        public TimeoutException() { }
        public TimeoutException(string message) { }
        public TimeoutException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TimeSpan : System.IComparable, System.IComparable<System.TimeSpan>, System.IEquatable<System.TimeSpan>, System.IFormattable
    {
        public static readonly System.TimeSpan MaxValue;
        public static readonly System.TimeSpan MinValue;
        public const long TicksPerDay = (long)864000000000;
        public const long TicksPerHour = (long)36000000000;
        public const long TicksPerMillisecond = (long)10000;
        public const long TicksPerMinute = (long)600000000;
        public const long TicksPerSecond = (long)10000000;
        public static readonly System.TimeSpan Zero;
        public TimeSpan(int hours, int minutes, int seconds) { throw new System.NotImplementedException(); }
        public TimeSpan(int days, int hours, int minutes, int seconds) { throw new System.NotImplementedException(); }
        public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { throw new System.NotImplementedException(); }
        public TimeSpan(long ticks) { throw new System.NotImplementedException(); }
        public int Days { get { return default(int); } }
        public int Hours { get { return default(int); } }
        public int Milliseconds { get { return default(int); } }
        public int Minutes { get { return default(int); } }
        public int Seconds { get { return default(int); } }
        public long Ticks { get { return default(long); } }
        public double TotalDays { get { return default(double); } }
        public double TotalHours { get { return default(double); } }
        public double TotalMilliseconds { get { return default(double); } }
        public double TotalMinutes { get { return default(double); } }
        public double TotalSeconds { get { return default(double); } }
        public System.TimeSpan Add(System.TimeSpan ts) { return default(System.TimeSpan); }
        public static int Compare(System.TimeSpan t1, System.TimeSpan t2) { return default(int); }
        public int CompareTo(object value) { return default(int); }
        public int CompareTo(System.TimeSpan value) { return default(int); }
        public System.TimeSpan Duration() { return default(System.TimeSpan); }
        public override bool Equals(object value) { return default(bool); }
        public bool Equals(System.TimeSpan obj) { return default(bool); }
        public static bool Equals(System.TimeSpan t1, System.TimeSpan t2) { return default(bool); }
        public static System.TimeSpan FromDays(double value) { return default(System.TimeSpan); }
        public static System.TimeSpan FromHours(double value) { return default(System.TimeSpan); }
        public static System.TimeSpan FromMilliseconds(double value) { return default(System.TimeSpan); }
        public static System.TimeSpan FromMinutes(double value) { return default(System.TimeSpan); }
        public static System.TimeSpan FromSeconds(double value) { return default(System.TimeSpan); }
        public static System.TimeSpan FromTicks(long value) { return default(System.TimeSpan); }
        public override int GetHashCode() { return default(int); }
        public System.TimeSpan Negate() { return default(System.TimeSpan); }
        public static System.TimeSpan operator +(System.TimeSpan t1, System.TimeSpan t2) { return default(System.TimeSpan); }
        public static bool operator ==(System.TimeSpan t1, System.TimeSpan t2) { return default(bool); }
        public static bool operator >(System.TimeSpan t1, System.TimeSpan t2) { return default(bool); }
        public static bool operator >=(System.TimeSpan t1, System.TimeSpan t2) { return default(bool); }
        public static bool operator !=(System.TimeSpan t1, System.TimeSpan t2) { return default(bool); }
        public static bool operator <(System.TimeSpan t1, System.TimeSpan t2) { return default(bool); }
        public static bool operator <=(System.TimeSpan t1, System.TimeSpan t2) { return default(bool); }
        public static System.TimeSpan operator -(System.TimeSpan t1, System.TimeSpan t2) { return default(System.TimeSpan); }
        public static System.TimeSpan operator -(System.TimeSpan t) { return default(System.TimeSpan); }
        public static System.TimeSpan operator +(System.TimeSpan t) { return default(System.TimeSpan); }
        public static System.TimeSpan Parse(string s) { return default(System.TimeSpan); }
        public static System.TimeSpan Parse(string input, System.IFormatProvider formatProvider) { return default(System.TimeSpan); }
        public static System.TimeSpan ParseExact(string input, string format, System.IFormatProvider formatProvider) { return default(System.TimeSpan); }
        public static System.TimeSpan ParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles) { return default(System.TimeSpan); }
        public static System.TimeSpan ParseExact(string input, string[] formats, System.IFormatProvider formatProvider) { return default(System.TimeSpan); }
        public static System.TimeSpan ParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles) { return default(System.TimeSpan); }
        public System.TimeSpan Subtract(System.TimeSpan ts) { return default(System.TimeSpan); }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
        public string ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
        public static bool TryParse(string input, System.IFormatProvider formatProvider, out System.TimeSpan result) { result = default(System.TimeSpan); return default(bool); }
        public static bool TryParse(string s, out System.TimeSpan result) { result = default(System.TimeSpan); return default(bool); }
        public static bool TryParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles, out System.TimeSpan result) { result = default(System.TimeSpan); return default(bool); }
        public static bool TryParseExact(string input, string format, System.IFormatProvider formatProvider, out System.TimeSpan result) { result = default(System.TimeSpan); return default(bool); }
        public static bool TryParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles, out System.TimeSpan result) { result = default(System.TimeSpan); return default(bool); }
        public static bool TryParseExact(string input, string[] formats, System.IFormatProvider formatProvider, out System.TimeSpan result) { result = default(System.TimeSpan); return default(bool); }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
    
    public sealed partial class TimeZoneInfo : System.IEquatable<System.TimeZoneInfo>
    {
        internal TimeZoneInfo() { }
        public System.TimeSpan BaseUtcOffset { get { return default(System.TimeSpan); } }
        public string DaylightName { get { return default(string); } }
        public string DisplayName { get { return default(string); } }
        public string Id { get { return default(string); } }
        public static System.TimeZoneInfo Local { get { return default(System.TimeZoneInfo); } }
        public string StandardName { get { return default(string); } }
        public bool SupportsDaylightSavingTime { get { return default(bool); } }
        public static System.TimeZoneInfo Utc { get { return default(System.TimeZoneInfo); } }
        public static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo destinationTimeZone) { return default(System.DateTime); }
        public static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo sourceTimeZone, System.TimeZoneInfo destinationTimeZone) { return default(System.DateTime); }
        public static System.DateTimeOffset ConvertTime(System.DateTimeOffset dateTimeOffset, System.TimeZoneInfo destinationTimeZone) { return default(System.DateTimeOffset); }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.TimeZoneInfo other) { return default(bool); }
        public static System.TimeZoneInfo FindSystemTimeZoneById(string id) { return default(System.TimeZoneInfo); }
        public System.TimeSpan[] GetAmbiguousTimeOffsets(System.DateTime dateTime) { return default(System.TimeSpan[]); }
        public System.TimeSpan[] GetAmbiguousTimeOffsets(System.DateTimeOffset dateTimeOffset) { return default(System.TimeSpan[]); }
        public override int GetHashCode() { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo> GetSystemTimeZones() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo>); }
        public System.TimeSpan GetUtcOffset(System.DateTime dateTime) { return default(System.TimeSpan); }
        public System.TimeSpan GetUtcOffset(System.DateTimeOffset dateTimeOffset) { return default(System.TimeSpan); }
        public bool IsAmbiguousTime(System.DateTime dateTime) { return default(bool); }
        public bool IsAmbiguousTime(System.DateTimeOffset dateTimeOffset) { return default(bool); }
        public bool IsDaylightSavingTime(System.DateTime dateTime) { return default(bool); }
        public bool IsDaylightSavingTime(System.DateTimeOffset dateTimeOffset) { return default(bool); }
        public bool IsInvalidTime(System.DateTime dateTime) { return default(bool); }
        public override string ToString() { return default(string); }
        [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
        
        public sealed partial class AdjustmentRule : System.IEquatable<System.TimeZoneInfo.AdjustmentRule>
        {
            internal AdjustmentRule() { }
            public static System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, System.TimeSpan daylightDelta, System.TimeZoneInfo.TransitionTime daylightTransitionStart, System.TimeZoneInfo.TransitionTime daylightTransitionEnd) { return default(System.TimeZoneInfo.AdjustmentRule); }
            public bool Equals(System.TimeZoneInfo.AdjustmentRule other) { return default(bool); }
            public override int GetHashCode() { return default(int); }
        }
        [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct TransitionTime : System.IEquatable<System.TimeZoneInfo.TransitionTime>
        {
            public override bool Equals(object obj) { return default(bool); }
            public bool Equals(System.TimeZoneInfo.TransitionTime other) { return default(bool); }
            public override int GetHashCode() { return default(int); }
        }
    }
    public static partial class Tuple
    {
        public static System.Tuple<T1> Create<T1>(T1 item1) { return default(System.Tuple<T1>); }
        public static System.Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) { return default(System.Tuple<T1, T2>); }
        public static System.Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) { return default(System.Tuple<T1, T2, T3>); }
        public static System.Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) { return default(System.Tuple<T1, T2, T3, T4>); }
        public static System.Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { return default(System.Tuple<T1, T2, T3, T4, T5>); }
        public static System.Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { return default(System.Tuple<T1, T2, T3, T4, T5, T6>); }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { return default(System.Tuple<T1, T2, T3, T4, T5, T6, T7>); }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) { return default(System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8>>); }
    }
    public partial class Tuple<T1> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1) { }
        public T1 Item1 { get { return default(T1); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class Tuple<T1, T2> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1, T2 item2) { }
        public T1 Item1 { get { return default(T1); } }
        public T2 Item2 { get { return default(T2); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class Tuple<T1, T2, T3> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1, T2 item2, T3 item3) { }
        public T1 Item1 { get { return default(T1); } }
        public T2 Item2 { get { return default(T2); } }
        public T3 Item3 { get { return default(T3); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class Tuple<T1, T2, T3, T4> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4) { }
        public T1 Item1 { get { return default(T1); } }
        public T2 Item2 { get { return default(T2); } }
        public T3 Item3 { get { return default(T3); } }
        public T4 Item4 { get { return default(T4); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class Tuple<T1, T2, T3, T4, T5> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }
        public T1 Item1 { get { return default(T1); } }
        public T2 Item2 { get { return default(T2); } }
        public T3 Item3 { get { return default(T3); } }
        public T4 Item4 { get { return default(T4); } }
        public T5 Item5 { get { return default(T5); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class Tuple<T1, T2, T3, T4, T5, T6> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { }
        public T1 Item1 { get { return default(T1); } }
        public T2 Item2 { get { return default(T2); } }
        public T3 Item3 { get { return default(T3); } }
        public T4 Item4 { get { return default(T4); } }
        public T5 Item5 { get { return default(T5); } }
        public T6 Item6 { get { return default(T6); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class Tuple<T1, T2, T3, T4, T5, T6, T7> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { }
        public T1 Item1 { get { return default(T1); } }
        public T2 Item2 { get { return default(T2); } }
        public T3 Item3 { get { return default(T3); } }
        public T4 Item4 { get { return default(T4); } }
        public T5 Item5 { get { return default(T5); } }
        public T6 Item6 { get { return default(T6); } }
        public T7 Item7 { get { return default(T7); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }
        public T1 Item1 { get { return default(T1); } }
        public T2 Item2 { get { return default(T2); } }
        public T3 Item3 { get { return default(T3); } }
        public T4 Item4 { get { return default(T4); } }
        public T5 Item5 { get { return default(T5); } }
        public T6 Item6 { get { return default(T6); } }
        public T7 Item7 { get { return default(T7); } }
        public TRest Rest { get { return default(TRest); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { return default(int); }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { return default(bool); }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { return default(int); }
        int System.IComparable.CompareTo(object obj) { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Type : System.Reflection.MemberInfo, System.Reflection.IReflect
    {
        public static readonly char Delimiter;
        public static readonly System.Type[] EmptyTypes;
        public static readonly System.Reflection.MemberFilter FilterNameIgnoreCase;
        public static readonly object Missing;
        protected Type() { }
        public abstract System.Reflection.Assembly Assembly { get; }
        public abstract string AssemblyQualifiedName { get; }
        public System.Reflection.TypeAttributes Attributes { get { return default(System.Reflection.TypeAttributes); } }
        public abstract System.Type BaseType { get; }
        public virtual bool ContainsGenericParameters { get { return default(bool); } }
        public virtual System.Reflection.MethodBase DeclaringMethod { get { return default(System.Reflection.MethodBase); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public static System.Reflection.Binder DefaultBinder { get { return default(System.Reflection.Binder); } }
        public abstract string FullName { get; }
        public virtual System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { return default(System.Reflection.GenericParameterAttributes); } }
        public virtual int GenericParameterPosition { get { return default(int); } }
        public virtual System.Type[] GenericTypeArguments { get { return default(System.Type[]); } }
        public abstract System.Guid GUID { get; }
        public bool HasElementType { get { return default(bool); } }
        public bool IsAbstract { get { return default(bool); } }
        public bool IsAnsiClass { get { return default(bool); } }
        public bool IsArray { get { return default(bool); } }
        public bool IsAutoClass { get { return default(bool); } }
        public bool IsAutoLayout { get { return default(bool); } }
        public bool IsByRef { get { return default(bool); } }
        public bool IsClass { get { return default(bool); } }
        public bool IsCOMObject { get { return default(bool); } }
        public virtual bool IsConstructedGenericType { get { return default(bool); } }
        public bool IsEnum { get { return default(bool); } }
        public bool IsExplicitLayout { get { return default(bool); } }
        public virtual bool IsGenericParameter { get { return default(bool); } }
        public virtual bool IsGenericType { get { return default(bool); } }
        public virtual bool IsGenericTypeDefinition { get { return default(bool); } }
        public bool IsImport { get { return default(bool); } }
        public bool IsInterface { [System.Security.SecuritySafeCriticalAttribute]get { return default(bool); } }
        public bool IsLayoutSequential { get { return default(bool); } }
        public bool IsMarshalByRef { get { return default(bool); } }
        public bool IsNested { get { return default(bool); } }
        public bool IsNestedAssembly { get { return default(bool); } }
        public bool IsNestedFamANDAssem { get { return default(bool); } }
        public bool IsNestedFamily { get { return default(bool); } }
        public bool IsNestedFamORAssem { get { return default(bool); } }
        public bool IsNestedPrivate { get { return default(bool); } }
        public bool IsNestedPublic { get { return default(bool); } }
        public bool IsNotPublic { get { return default(bool); } }
        public bool IsPointer { get { return default(bool); } }
        public bool IsPrimitive { get { return default(bool); } }
        public bool IsPublic { get { return default(bool); } }
        public bool IsSealed { get { return default(bool); } }
        public virtual bool IsSerializable { get { return default(bool); } }
        public bool IsSpecialName { get { return default(bool); } }
        public bool IsUnicodeClass { get { return default(bool); } }
        public bool IsValueType { get { return default(bool); } }
        public bool IsVisible { get { return default(bool); } }
        public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
        public abstract new System.Reflection.Module Module { get; }
        public abstract string Namespace { get; }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public virtual System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute { get { return default(System.Runtime.InteropServices.StructLayoutAttribute); } }
        public virtual System.RuntimeTypeHandle TypeHandle { get { return default(System.RuntimeTypeHandle); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.ConstructorInfo TypeInitializer { get { return default(System.Reflection.ConstructorInfo); } }
        public abstract System.Type UnderlyingSystemType { get; }
        public override bool Equals(object o) { return default(bool); }
        public bool Equals(System.Type o) { return default(bool); }
        public virtual System.Type[] FindInterfaces(System.Reflection.TypeFilter filter, object filterCriteria) { return default(System.Type[]); }
        public virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes memberType, System.Reflection.BindingFlags bindingAttr, System.Reflection.MemberFilter filter, object filterCriteria) { return default(System.Reflection.MemberInfo[]); }
        public virtual int GetArrayRank() { return default(int); }
        protected abstract System.Reflection.TypeAttributes GetAttributeFlagsImpl();
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.ConstructorInfo); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.ConstructorInfo GetConstructor(System.Type[] types) { return default(System.Reflection.ConstructorInfo); }
        protected abstract System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.ConstructorInfo[] GetConstructors() { return default(System.Reflection.ConstructorInfo[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public abstract System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr);
        public virtual System.Reflection.MemberInfo[] GetDefaultMembers() { return default(System.Reflection.MemberInfo[]); }
        public abstract System.Type GetElementType();
        public virtual string GetEnumName(object value) { return default(string); }
        public virtual string[] GetEnumNames() { return default(string[]); }
        public virtual System.Type GetEnumUnderlyingType() { return default(System.Type); }
        public virtual System.Array GetEnumValues() { return default(System.Array); }
        public System.Reflection.EventInfo GetEvent(string name) { return default(System.Reflection.EventInfo); }
        public abstract System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr);
        public virtual System.Reflection.EventInfo[] GetEvents() { return default(System.Reflection.EventInfo[]); }
        public abstract System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.FieldInfo GetField(string name) { return default(System.Reflection.FieldInfo); }
        public abstract System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.FieldInfo[] GetFields() { return default(System.Reflection.FieldInfo[]); }
        public abstract System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr);
        public virtual System.Type[] GetGenericArguments() { return default(System.Type[]); }
        public virtual System.Type[] GetGenericParameterConstraints() { return default(System.Type[]); }
        public virtual System.Type GetGenericTypeDefinition() { return default(System.Type); }
        public override int GetHashCode() { return default(int); }
        public System.Type GetInterface(string name) { return default(System.Type); }
        public abstract System.Type GetInterface(string name, bool ignoreCase);
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { return default(System.Reflection.InterfaceMapping); }
        public abstract System.Type[] GetInterfaces();
        public System.Reflection.MemberInfo[] GetMember(string name) { return default(System.Reflection.MemberInfo[]); }
        public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        public System.Reflection.MemberInfo[] GetMembers() { return default(System.Reflection.MemberInfo[]); }
        public abstract System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.MethodInfo GetMethod(string name) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        protected abstract System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        public System.Reflection.MethodInfo[] GetMethods() { return default(System.Reflection.MethodInfo[]); }
        public abstract System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr);
        public System.Type GetNestedType(string name) { return default(System.Type); }
        public abstract System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr);
        public System.Type[] GetNestedTypes() { return default(System.Type[]); }
        public abstract System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.PropertyInfo[] GetProperties() { return default(System.Reflection.PropertyInfo[]); }
        public abstract System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.PropertyInfo GetProperty(string name) { return default(System.Reflection.PropertyInfo); }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo); }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.PropertyInfo); }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType) { return default(System.Reflection.PropertyInfo); }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types) { return default(System.Reflection.PropertyInfo); }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.PropertyInfo); }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type[] types) { return default(System.Reflection.PropertyInfo); }
        protected abstract System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Type GetType(string typeName) { return default(System.Type); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Type GetType(string typeName, bool throwOnError) { return default(System.Type); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Type GetType(string typeName, bool throwOnError, bool ignoreCase) { return default(System.Type); }
        public static System.TypeCode GetTypeCode(System.Type type) { return default(System.TypeCode); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Type GetTypeFromHandle(System.RuntimeTypeHandle handle) { return default(System.Type); }
        public static System.RuntimeTypeHandle GetTypeHandle(object o) { return default(System.RuntimeTypeHandle); }
        protected abstract bool HasElementTypeImpl();
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args) { return default(object); }
        public abstract object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters);
        protected abstract bool IsArrayImpl();
        public virtual bool IsAssignableFrom(System.Type c) { return default(bool); }
        protected abstract bool IsByRefImpl();
        protected abstract bool IsCOMObjectImpl();
        public virtual bool IsEnumDefined(object value) { return default(bool); }
        public virtual bool IsEquivalentTo(System.Type other) { return default(bool); }
        public virtual bool IsInstanceOfType(object o) { return default(bool); }
        protected abstract bool IsPointerImpl();
        protected abstract bool IsPrimitiveImpl();
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual bool IsSubclassOf(System.Type c) { return default(bool); }
        protected virtual bool IsValueTypeImpl() { return default(bool); }
        public virtual System.Type MakeArrayType() { return default(System.Type); }
        public virtual System.Type MakeArrayType(int rank) { return default(System.Type); }
        public virtual System.Type MakeByRefType() { return default(System.Type); }
        public virtual System.Type MakeGenericType(params System.Type[] typeArguments) { return default(System.Type); }
        public virtual System.Type MakePointerType() { return default(System.Type); }
        public override string ToString() { return default(string); }
    }
    public partial class TypeAccessException : System.TypeLoadException
    {
        public TypeAccessException() { }
        public TypeAccessException(string message) { }
        public TypeAccessException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TypeCode
    {
        Boolean = 3,
        Byte = 6,
        Char = 4,
        DateTime = 16,
        DBNull = 2,
        Decimal = 15,
        Double = 14,
        Empty = 0,
        Int16 = 7,
        Int32 = 9,
        Int64 = 11,
        Object = 1,
        SByte = 5,
        Single = 13,
        String = 18,
        UInt16 = 8,
        UInt32 = 10,
        UInt64 = 12,
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TypedReference
    {
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class TypeInitializationException : System.SystemException
    {
        public TypeInitializationException(string fullTypeName, System.Exception innerException) { }
        public string TypeName { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TypeLoadException : System.SystemException
    {
        public TypeLoadException() { }
        public TypeLoadException(string message) { }
        public TypeLoadException(string message, System.Exception inner) { }
        public override string Message { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public string TypeName { get { return default(string); } }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct UInt16 : System.IComparable, System.IComparable<ushort>, System.IConvertible, System.IEquatable<ushort>, System.IFormattable
    {
        public const ushort MaxValue = (ushort)65535;
        public const ushort MinValue = (ushort)0;
        public int CompareTo(object value) { return default(int); }
        public int CompareTo(ushort value) { return default(int); }
        public override bool Equals(object obj) { return default(bool); }
        
        public bool Equals(ushort obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        [System.CLSCompliantAttribute(false)]
        public static ushort Parse(string s) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort Parse(string s, System.Globalization.NumberStyles style) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort Parse(string s, System.IFormatProvider provider) { return default(ushort); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out ushort result) { result = default(ushort); return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out ushort result) { result = default(ushort); return default(bool); }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct UInt32 : System.IComparable, System.IComparable<uint>, System.IConvertible, System.IEquatable<uint>, System.IFormattable
    {
        public const uint MaxValue = (uint)4294967295;
        public const uint MinValue = (uint)0;
        public int CompareTo(object value) { return default(int); }
        public int CompareTo(uint value) { return default(int); }
        public override bool Equals(object obj) { return default(bool); }
        
        public bool Equals(uint obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        [System.CLSCompliantAttribute(false)]
        public static uint Parse(string s) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint Parse(string s, System.Globalization.NumberStyles style) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint Parse(string s, System.IFormatProvider provider) { return default(uint); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out uint result) { result = default(uint); return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out uint result) { result = default(uint); return default(bool); }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct UInt64 : System.IComparable, System.IComparable<ulong>, System.IConvertible, System.IEquatable<ulong>, System.IFormattable
    {
        public const ulong MaxValue = (ulong)18446744073709551615;
        public const ulong MinValue = (ulong)0;
        public int CompareTo(object value) { return default(int); }
        public int CompareTo(ulong value) { return default(int); }
        public override bool Equals(object obj) { return default(bool); }
        
        public bool Equals(ulong obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public System.TypeCode GetTypeCode() { return default(System.TypeCode); }
        [System.CLSCompliantAttribute(false)]
        public static ulong Parse(string s) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong Parse(string s, System.Globalization.NumberStyles style) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong Parse(string s, System.IFormatProvider provider) { return default(ulong); }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { return default(bool); }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { return default(byte); }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { return default(char); }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { return default(System.DateTime); }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { return default(decimal); }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { return default(double); }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { return default(short); }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { return default(int); }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { return default(long); }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { return default(sbyte); }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { return default(float); }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { return default(object); }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { return default(ushort); }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { return default(uint); }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { return default(ulong); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(System.IFormatProvider provider) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(string format, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out ulong result) { result = default(ulong); return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out ulong result) { result = default(ulong); return default(bool); }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct UIntPtr
    {
        public static readonly System.UIntPtr Zero;
        
        [System.Security.SecuritySafeCriticalAttribute]
        public UIntPtr(uint value) { throw new System.NotImplementedException(); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public UIntPtr(ulong value) { throw new System.NotImplementedException(); }
        [System.CLSCompliantAttribute(false)]
        
        [System.Security.SecurityCriticalAttribute]
        public unsafe UIntPtr(void* value) { throw new System.NotImplementedException(); }
        public static int Size { get { return default(int); } }
        
        public static System.UIntPtr Add(System.UIntPtr pointer, int offset) { return default(System.UIntPtr); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        
        public static System.UIntPtr operator +(System.UIntPtr pointer, int offset) { return default(System.UIntPtr); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator ==(System.UIntPtr value1, System.UIntPtr value2) { return default(bool); }
        
        public static explicit operator System.UIntPtr (uint value) { return default(System.UIntPtr); }
        
        public static explicit operator System.UIntPtr (ulong value) { return default(System.UIntPtr); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static explicit operator uint (System.UIntPtr value) { return default(uint); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static explicit operator ulong (System.UIntPtr value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        
        [System.Security.SecurityCriticalAttribute]
        public unsafe static explicit operator void* (System.UIntPtr value) { return default(void*); }
        [System.CLSCompliantAttribute(false)]
        
        [System.Security.SecurityCriticalAttribute]
        public unsafe static explicit operator System.UIntPtr (void* value) { return default(System.UIntPtr); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool operator !=(System.UIntPtr value1, System.UIntPtr value2) { return default(bool); }
        
        public static System.UIntPtr operator -(System.UIntPtr pointer, int offset) { return default(System.UIntPtr); }
        
        public static System.UIntPtr Subtract(System.UIntPtr pointer, int offset) { return default(System.UIntPtr); }
        [System.CLSCompliantAttribute(false)]
        
        [System.Security.SecuritySafeCriticalAttribute]
        public unsafe void* ToPointer() { return default(void*); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public uint ToUInt32() { return default(uint); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public ulong ToUInt64() { return default(ulong); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class UnauthorizedAccessException : System.SystemException
    {
        public UnauthorizedAccessException() { }
        public UnauthorizedAccessException(string message) { }
        public UnauthorizedAccessException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class UnhandledExceptionEventArgs : System.EventArgs
    {
        public UnhandledExceptionEventArgs(object exception, bool isTerminating) { }
        public object ExceptionObject { get { return default(object); } }
        public bool IsTerminating { get { return default(bool); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public delegate void UnhandledExceptionEventHandler(object sender, System.UnhandledExceptionEventArgs e);
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class ValueType
    {
        protected ValueType() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Version : System.IComparable, System.IComparable<System.Version>, System.IEquatable<System.Version>
    {
        public Version(int major, int minor) { }
        public Version(int major, int minor, int build) { }
        public Version(int major, int minor, int build, int revision) { }
        public Version(string version) { }
        public int Build { get { return default(int); } }
        public int Major { get { return default(int); } }
        public short MajorRevision { get { return default(short); } }
        public int Minor { get { return default(int); } }
        public short MinorRevision { get { return default(short); } }
        public int Revision { get { return default(int); } }
        public object Clone() { return default(object); }
        public int CompareTo(object version) { return default(int); }
        public int CompareTo(System.Version value) { return default(int); }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Version obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Version v1, System.Version v2) { return default(bool); }
        public static bool operator >(System.Version v1, System.Version v2) { return default(bool); }
        public static bool operator >=(System.Version v1, System.Version v2) { return default(bool); }
        public static bool operator !=(System.Version v1, System.Version v2) { return default(bool); }
        public static bool operator <(System.Version v1, System.Version v2) { return default(bool); }
        public static bool operator <=(System.Version v1, System.Version v2) { return default(bool); }
        public static System.Version Parse(string input) { return default(System.Version); }
        public override string ToString() { return default(string); }
        public string ToString(int fieldCount) { return default(string); }
        public static bool TryParse(string input, out System.Version result) { result = default(System.Version); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    public partial struct Void
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class WeakReference
    {
        [System.Security.SecuritySafeCriticalAttribute]
        protected WeakReference() { }
        public WeakReference(object target) { }
        public WeakReference(object target, bool trackResurrection) { }
        public virtual bool IsAlive { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(bool); } }
        public virtual object Target { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(object); } [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]set { } }
        public virtual bool TrackResurrection { get { return default(bool); } }
        ~WeakReference() { }
    }
    public sealed partial class WeakReference<T> where T : class
    {
        public WeakReference(T target) { }
        public WeakReference(T target, bool trackResurrection) { }
        ~WeakReference() { }
        public void SetTarget(T target) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public bool TryGetTarget(out T target) { target = default(T); return default(bool); }
    }
}
namespace System.Collections
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class BitArray : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public BitArray(bool[] values) { }
        public BitArray(byte[] bytes) { }
        public BitArray(System.Collections.BitArray bits) { }
        public BitArray(int length) { }
        public BitArray(int length, bool defaultValue) { }
        public BitArray(int[] values) { }
        public int Count { get { return default(int); } }
        public bool IsReadOnly { get { return default(bool); } }
        public bool IsSynchronized { get { return default(bool); } }
        public bool this[int index] { get { return default(bool); } set { } }
        public int Length { get { return default(int); } set { } }
        public object SyncRoot { get { return default(object); } }
        public System.Collections.BitArray And(System.Collections.BitArray value) { return default(System.Collections.BitArray); }
        public object Clone() { return default(object); }
        public void CopyTo(System.Array array, int index) { }
        public bool Get(int index) { return default(bool); }
        public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        public System.Collections.BitArray Not() { return default(System.Collections.BitArray); }
        public System.Collections.BitArray Or(System.Collections.BitArray value) { return default(System.Collections.BitArray); }
        public void Set(int index, bool value) { }
        public void SetAll(bool value) { }
        public System.Collections.BitArray Xor(System.Collections.BitArray value) { return default(System.Collections.BitArray); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        protected CollectionBase() { }
        public int Count { get { return default(int); } }
        protected System.Collections.IList List { get { return default(System.Collections.IList); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
        object System.Collections.IList.this[int index] { get { return default(object); } set { } }
        public void Clear() { }
        public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        int System.Collections.IList.Add(object value) { return default(int); }
        bool System.Collections.IList.Contains(object value) { return default(bool); }
        int System.Collections.IList.IndexOf(object value) { return default(int); }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DictionaryEntry
    {
        public DictionaryEntry(object key, object value) { throw new System.NotImplementedException(); }
        public object Key { get { return default(object); } set { } }
        public object Value { get { return default(object); } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ICollection : System.Collections.IEnumerable
    {
        int Count { get; }
        bool IsSynchronized { get; }
        object SyncRoot { get; }
        void CopyTo(System.Array array, int index);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IComparer
    {
        int Compare(object x, object y);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IDictionary : System.Collections.ICollection, System.Collections.IEnumerable
    {
        bool IsFixedSize { get; }
        bool IsReadOnly { get; }
        object this[object key] { get; set; }
        System.Collections.ICollection Keys { get; }
        System.Collections.ICollection Values { get; }
        void Add(object key, object value);
        void Clear();
        bool Contains(object key);
        new System.Collections.IDictionaryEnumerator GetEnumerator();
        void Remove(object key);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IDictionaryEnumerator : System.Collections.IEnumerator
    {
        System.Collections.DictionaryEntry Entry { get; }
        object Key { get; }
        object Value { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("496B0ABE-CDEE-11d3-88E8-00902754C43A")]
    public partial interface IEnumerable
    {
        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        System.Collections.IEnumerator GetEnumerator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("496B0ABF-CDEE-11d3-88E8-00902754C43A")]
    public partial interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IEqualityComparer
    {
        bool Equals(object x, object y);
        int GetHashCode(object obj);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IList : System.Collections.ICollection, System.Collections.IEnumerable
    {
        bool IsFixedSize { get; }
        bool IsReadOnly { get; }
        object this[int index] { get; set; }
        int Add(object value);
        void Clear();
        bool Contains(object value);
        int IndexOf(object value);
        void Insert(int index, object value);
        void Remove(object value);
        void RemoveAt(int index);
    }
    public partial interface IStructuralComparable
    {
        int CompareTo(object other, System.Collections.IComparer comparer);
    }
    public partial interface IStructuralEquatable
    {
        bool Equals(object other, System.Collections.IEqualityComparer comparer);
        int GetHashCode(System.Collections.IEqualityComparer comparer);
    }
    public static partial class StructuralComparisons
    {
        public static System.Collections.IComparer StructuralComparer { get { return default(System.Collections.IComparer); } }
        public static System.Collections.IEqualityComparer StructuralEqualityComparer { get { return default(System.Collections.IEqualityComparer); } }
    }
}
namespace System.Collections.Generic
{
    public abstract partial class Comparer<T> : System.Collections.Generic.IComparer<T>, System.Collections.IComparer
    {
        protected Comparer() { }
        public static System.Collections.Generic.Comparer<T> Default { get { return default(System.Collections.Generic.Comparer<T>); } }
        public abstract int Compare(T x, T y);
        public static System.Collections.Generic.Comparer<T> Create(System.Comparison<T> comparison) { return default(System.Collections.Generic.Comparer<T>); }
        int System.Collections.IComparer.Compare(object x, object y) { return default(int); }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class Dictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public Dictionary() { }
        public Dictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public Dictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public Dictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public Dictionary(int capacity) { }
        public Dictionary(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get { return default(System.Collections.Generic.IEqualityComparer<TKey>); } }
        public int Count { get { return default(int); } }
        public TValue this[TKey key] { get { return default(TValue); } set { } }
        public System.Collections.Generic.Dictionary<TKey, TValue>.KeyCollection Keys { get { return default(System.Collections.Generic.Dictionary<TKey, TValue>.KeyCollection); } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { return default(bool); } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
        System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get { return default(System.Collections.Generic.IEnumerable<TKey>); } }
        System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get { return default(System.Collections.Generic.IEnumerable<TValue>); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
        object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
        public System.Collections.Generic.Dictionary<TKey, TValue>.ValueCollection Values { get { return default(System.Collections.Generic.Dictionary<TKey, TValue>.ValueCollection); } }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { return default(bool); }
        public bool ContainsValue(TValue value) { return default(bool); }
        public System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator GetEnumerator() { return default(System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator); }
        public bool Remove(TKey key) { return default(bool); }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator, System.IDisposable
        {
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get { return default(System.Collections.Generic.KeyValuePair<TKey, TValue>); } }
            System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get { return default(System.Collections.DictionaryEntry); } }
            object System.Collections.IDictionaryEnumerator.Key { get { return default(object); } }
            object System.Collections.IDictionaryEnumerator.Value { get { return default(object); } }
            object System.Collections.IEnumerator.Current { get { return default(object); } }
            public void Dispose() { }
            public bool MoveNext() { return default(bool); }
            void System.Collections.IEnumerator.Reset() { }
        }
        [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
        public sealed partial class KeyCollection : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.Generic.IReadOnlyCollection<TKey>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            public KeyCollection(System.Collections.Generic.Dictionary<TKey, TValue> dictionary) { }
            public int Count { get { return default(int); } }
            bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get { return default(bool); } }
            bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
            object System.Collections.ICollection.SyncRoot { get { return default(object); } }
            public void CopyTo(TKey[] array, int index) { }
            public System.Collections.Generic.Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator() { return default(System.Collections.Generic.Dictionary<TKey, TValue>.KeyCollection.Enumerator); }
            void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
            void System.Collections.Generic.ICollection<TKey>.Clear() { }
            bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { return default(bool); }
            bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { return default(bool); }
            System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TKey>); }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public partial struct Enumerator : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
            {
                public TKey Current { get { return default(TKey); } }
                object System.Collections.IEnumerator.Current { get { return default(object); } }
                public void Dispose() { }
                public bool MoveNext() { return default(bool); }
                void System.Collections.IEnumerator.Reset() { }
            }
        }
        [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
        public sealed partial class ValueCollection : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.Generic.IReadOnlyCollection<TValue>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            public ValueCollection(System.Collections.Generic.Dictionary<TKey, TValue> dictionary) { }
            public int Count { get { return default(int); } }
            bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get { return default(bool); } }
            bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
            object System.Collections.ICollection.SyncRoot { get { return default(object); } }
            public void CopyTo(TValue[] array, int index) { }
            public System.Collections.Generic.Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator() { return default(System.Collections.Generic.Dictionary<TKey, TValue>.ValueCollection.Enumerator); }
            void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
            void System.Collections.Generic.ICollection<TValue>.Clear() { }
            bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { return default(bool); }
            bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { return default(bool); }
            System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TValue>); }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public partial struct Enumerator : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
            {
                public TValue Current { get { return default(TValue); } }
                object System.Collections.IEnumerator.Current { get { return default(object); } }
                public void Dispose() { }
                public bool MoveNext() { return default(bool); }
                void System.Collections.IEnumerator.Reset() { }
            }
        }
    }
    public abstract partial class EqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>, System.Collections.IEqualityComparer
    {
        protected EqualityComparer() { }
        public static System.Collections.Generic.EqualityComparer<T> Default { get { return default(System.Collections.Generic.EqualityComparer<T>); } }
        public abstract bool Equals(T x, T y);
        public abstract int GetHashCode(T obj);
        bool System.Collections.IEqualityComparer.Equals(object x, object y) { return default(bool); }
        int System.Collections.IEqualityComparer.GetHashCode(object obj) { return default(int); }
    }
    public partial interface ICollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        int Count { get; }
        bool IsReadOnly { get; }
        void Add(T item);
        void Clear();
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex);
        bool Remove(T item);
    }
    public partial interface IComparer<in T>
    {
        int Compare(T x, T y);
    }
    public partial interface IDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    {
        TValue this[TKey key] { get; set; }
        System.Collections.Generic.ICollection<TKey> Keys { get; }
        System.Collections.Generic.ICollection<TValue> Values { get; }
        void Add(TKey key, TValue value);
        bool ContainsKey(TKey key);
        bool Remove(TKey key);
        bool TryGetValue(TKey key, out TValue value);
    }
    public partial interface IEnumerable<out T> : System.Collections.IEnumerable
    {
        new System.Collections.Generic.IEnumerator<T> GetEnumerator();
    }
    public partial interface IEnumerator<out T> : System.Collections.IEnumerator, System.IDisposable
    {
        new T Current { get; }
    }
    public partial interface IEqualityComparer<in T>
    {
        bool Equals(T x, T y);
        int GetHashCode(T obj);
    }
    public partial interface IList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        T this[int index] { get; set; }
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
    }
    public partial interface IReadOnlyCollection<out T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        int Count { get; }
    }
    public partial interface IReadOnlyDictionary<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    {
        TValue this[TKey key] { get; }
        System.Collections.Generic.IEnumerable<TKey> Keys { get; }
        System.Collections.Generic.IEnumerable<TValue> Values { get; }
        bool ContainsKey(TKey key);
        bool TryGetValue(TKey key, out TValue value);
    }
    public partial interface IReadOnlyList<out T> : System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.IEnumerable
    {
        T this[int index] { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class KeyNotFoundException : System.SystemException
    {
        public KeyNotFoundException() { }
        public KeyNotFoundException(string message) { }
        public KeyNotFoundException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct KeyValuePair<TKey, TValue>
    {
        public KeyValuePair(TKey key, TValue value) { throw new System.NotImplementedException(); }
        public TKey Key { get { return default(TKey); } }
        public TValue Value { get { return default(TValue); } }
        public override string ToString() { return default(string); }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    public partial class List<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public List() { }
        public List(System.Collections.Generic.IEnumerable<T> collection) { }
        public List(int capacity) { }
        public int Capacity { get { return default(int); } set { } }
        public int Count { get { return default(int); } }
        public T this[int index] { get { return default(T); } set { } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
        object System.Collections.IList.this[int index] { get { return default(object); } set { } }
        public void Add(T item) { }
        public void AddRange(System.Collections.Generic.IEnumerable<T> collection) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly() { return default(System.Collections.ObjectModel.ReadOnlyCollection<T>); }
        public int BinarySearch(T item) { return default(int); }
        public int BinarySearch(T item, System.Collections.Generic.IComparer<T> comparer) { return default(int); }
        public int BinarySearch(int index, int count, T item, System.Collections.Generic.IComparer<T> comparer) { return default(int); }
        public void Clear() { }
        public bool Contains(T item) { return default(bool); }
        public void CopyTo(T[] array) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public void CopyTo(int index, T[] array, int arrayIndex, int count) { }
        public bool Exists(System.Predicate<T> match) { return default(bool); }
        public T Find(System.Predicate<T> match) { return default(T); }
        public System.Collections.Generic.List<T> FindAll(System.Predicate<T> match) { return default(System.Collections.Generic.List<T>); }
        public int FindIndex(int startIndex, int count, System.Predicate<T> match) { return default(int); }
        public int FindIndex(int startIndex, System.Predicate<T> match) { return default(int); }
        public int FindIndex(System.Predicate<T> match) { return default(int); }
        public T FindLast(System.Predicate<T> match) { return default(T); }
        public int FindLastIndex(int startIndex, int count, System.Predicate<T> match) { return default(int); }
        public int FindLastIndex(int startIndex, System.Predicate<T> match) { return default(int); }
        public int FindLastIndex(System.Predicate<T> match) { return default(int); }
        public void ForEach(System.Action<T> action) { }
        public System.Collections.Generic.List<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.List<T>.Enumerator); }
        public System.Collections.Generic.List<T> GetRange(int index, int count) { return default(System.Collections.Generic.List<T>); }
        public int IndexOf(T item) { return default(int); }
        public int IndexOf(T item, int index) { return default(int); }
        public int IndexOf(T item, int index, int count) { return default(int); }
        public void Insert(int index, T item) { }
        public void InsertRange(int index, System.Collections.Generic.IEnumerable<T> collection) { }
        public int LastIndexOf(T item) { return default(int); }
        public int LastIndexOf(T item, int index) { return default(int); }
        public int LastIndexOf(T item, int index, int count) { return default(int); }
        public bool Remove(T item) { return default(bool); }
        public int RemoveAll(System.Predicate<T> match) { return default(int); }
        public void RemoveAt(int index) { }
        public void RemoveRange(int index, int count) { }
        public void Reverse() { }
        public void Reverse(int index, int count) { }
        public void Sort() { }
        public void Sort(System.Collections.Generic.IComparer<T> comparer) { }
        public void Sort(System.Comparison<T> comparison) { }
        public void Sort(int index, int count, System.Collections.Generic.IComparer<T> comparer) { }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
        void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        int System.Collections.IList.Add(object item) { return default(int); }
        bool System.Collections.IList.Contains(object item) { return default(bool); }
        int System.Collections.IList.IndexOf(object item) { return default(int); }
        void System.Collections.IList.Insert(int index, object item) { }
        void System.Collections.IList.Remove(object item) { }
        public T[] ToArray() { return default(T[]); }
        public void TrimExcess() { }
        public bool TrueForAll(System.Predicate<T> match) { return default(bool); }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            public T Current { get { return default(T); } }
            object System.Collections.IEnumerator.Current { get { return default(object); } }
            public void Dispose() { }
            public bool MoveNext() { return default(bool); }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
}
namespace System.Collections.ObjectModel
{
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class Collection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public Collection() { }
        public Collection(System.Collections.Generic.IList<T> list) { }
        public int Count { get { return default(int); } }
        public T this[int index] { get { return default(T); } set { } }
        protected System.Collections.Generic.IList<T> Items { get { return default(System.Collections.Generic.IList<T>); } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
        object System.Collections.IList.this[int index] { get { return default(object); } set { } }
        public void Add(T item) { }
        public void Clear() { }
        protected virtual void ClearItems() { }
        public bool Contains(T item) { return default(bool); }
        public void CopyTo(T[] array, int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
        public int IndexOf(T item) { return default(int); }
        public void Insert(int index, T item) { }
        protected virtual void InsertItem(int index, T item) { }
        public bool Remove(T item) { return default(bool); }
        public void RemoveAt(int index) { }
        protected virtual void RemoveItem(int index) { }
        protected virtual void SetItem(int index, T item) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        int System.Collections.IList.Add(object value) { return default(int); }
        bool System.Collections.IList.Contains(object value) { return default(bool); }
        int System.Collections.IList.IndexOf(object value) { return default(int); }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public abstract partial class KeyedCollection<TKey, TItem> : System.Collections.ObjectModel.Collection<TItem>
    {
        protected KeyedCollection() { }
        protected KeyedCollection(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        protected KeyedCollection(System.Collections.Generic.IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get { return default(System.Collections.Generic.IEqualityComparer<TKey>); } }
        protected System.Collections.Generic.IDictionary<TKey, TItem> Dictionary { get { return default(System.Collections.Generic.IDictionary<TKey, TItem>); } }
        public TItem this[TKey key] { get { return default(TItem); } }
        protected void ChangeItemKey(TItem item, TKey newKey) { }
        protected override void ClearItems() { }
        public bool Contains(TKey key) { return default(bool); }
        protected abstract TKey GetKeyForItem(TItem item);
        protected override void InsertItem(int index, TItem item) { }
        public bool Remove(TKey key) { return default(bool); }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, TItem item) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class ReadOnlyCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public ReadOnlyCollection(System.Collections.Generic.IList<T> list) { }
        public int Count { get { return default(int); } }
        public T this[int index] { get { return default(T); } }
        protected System.Collections.Generic.IList<T> Items { get { return default(System.Collections.Generic.IList<T>); } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
        T System.Collections.Generic.IList<T>.this[int index] { get { return default(T); } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
        object System.Collections.IList.this[int index] { get { return default(object); } set { } }
        public bool Contains(T value) { return default(bool); }
        public void CopyTo(T[] array, int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
        public int IndexOf(T value) { return default(int); }
        void System.Collections.Generic.ICollection<T>.Add(T value) { }
        void System.Collections.Generic.ICollection<T>.Clear() { }
        bool System.Collections.Generic.ICollection<T>.Remove(T value) { return default(bool); }
        void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        int System.Collections.IList.Add(object value) { return default(int); }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { return default(bool); }
        int System.Collections.IList.IndexOf(object value) { return default(int); }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    public partial class ReadOnlyDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public ReadOnlyDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public int Count { get { return default(int); } }
        protected System.Collections.Generic.IDictionary<TKey, TValue> Dictionary { get { return default(System.Collections.Generic.IDictionary<TKey, TValue>); } }
        public TValue this[TKey key] { get { return default(TValue); } }
        public System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>.KeyCollection Keys { get { return default(System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>.KeyCollection); } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { return default(bool); } }
        TValue System.Collections.Generic.IDictionary<TKey,TValue>.this[TKey key] { get { return default(TValue); } set { } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
        System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get { return default(System.Collections.Generic.IEnumerable<TKey>); } }
        System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get { return default(System.Collections.Generic.IEnumerable<TValue>); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
        object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
        public System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>.ValueCollection Values { get { return default(System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>.ValueCollection); } }
        public bool ContainsKey(TKey key) { return default(bool); }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
        void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
        bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { return default(bool); }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        void System.Collections.IDictionary.Clear() { }
        bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
        [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
        public sealed partial class KeyCollection : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.Generic.IReadOnlyCollection<TKey>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            internal KeyCollection() { }
            public int Count { get { return default(int); } }
            bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get { return default(bool); } }
            bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
            object System.Collections.ICollection.SyncRoot { get { return default(object); } }
            public void CopyTo(TKey[] array, int arrayIndex) { }
            public System.Collections.Generic.IEnumerator<TKey> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TKey>); }
            void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
            void System.Collections.Generic.ICollection<TKey>.Clear() { }
            bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { return default(bool); }
            bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { return default(bool); }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        }
        [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
                public sealed partial class ValueCollection : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.Generic.IReadOnlyCollection<TValue>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            internal ValueCollection() { }
            public int Count { get { return default(int); } }
            bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get { return default(bool); } }
            bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
            object System.Collections.ICollection.SyncRoot { get { return default(object); } }
            public void CopyTo(TValue[] array, int arrayIndex) { }
            public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TValue>); }
            void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
            void System.Collections.Generic.ICollection<TValue>.Clear() { }
            bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { return default(bool); }
            bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { return default(bool); }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        }
    }
}
namespace System.Configuration.Assemblies
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum AssemblyHashAlgorithm
    {
        MD5 = 32771,
        None = 0,
        SHA1 = 32772,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        SHA256 = 32780,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        SHA384 = 32781,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        SHA512 = 32782,
    }
}
namespace System.Diagnostics
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ConditionalAttribute : System.Attribute
    {
        public ConditionalAttribute(string conditionString) { }
        public string ConditionString { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(3), AllowMultiple=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DebuggableAttribute : System.Attribute
    {
        public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled) { }
        public DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes modes) { }
        [System.FlagsAttribute]
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public enum DebuggingModes
        {
            Default = 1,
            DisableOptimizations = 256,
            EnableEditAndContinue = 4,
            IgnoreSymbolStoreSequencePoints = 2,
            None = 0,
        }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Debugger
    {
        [System.ObsoleteAttribute("Do not create instances of the Debugger class.  Call the static methods directly on this type instead", true)]
        public Debugger() { }
        public static bool IsAttached { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(bool); } }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Break() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static bool IsLogging() { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool Launch() { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static void Log(int level, string category, string message) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static void NotifyOfCrossThreadDependency() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DebuggerBrowsableAttribute : System.Attribute
    {
        public DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState state) { }
        public System.Diagnostics.DebuggerBrowsableState State { get { return default(System.Diagnostics.DebuggerBrowsableState); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DebuggerBrowsableState
    {
        Collapsed = 2,
        Never = 0,
        RootHidden = 3,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4509), AllowMultiple=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DebuggerDisplayAttribute : System.Attribute
    {
        public DebuggerDisplayAttribute(string value) { }
        public string Name { get { return default(string); } set { } }
        public System.Type Target { get { return default(System.Type); } set { } }
        public string TargetTypeName { get { return default(string); } set { } }
        public string Type { get { return default(string); } set { } }
        public string Value { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(224), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DebuggerHiddenAttribute : System.Attribute
    {
        public DebuggerHiddenAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(236), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DebuggerNonUserCodeAttribute : System.Attribute
    {
        public DebuggerNonUserCodeAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(108), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DebuggerStepThroughAttribute : System.Attribute
    {
        public DebuggerStepThroughAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(13), AllowMultiple=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DebuggerTypeProxyAttribute : System.Attribute
    {
        public DebuggerTypeProxyAttribute(string typeName) { }
        public DebuggerTypeProxyAttribute(System.Type type) { }
        public string ProxyTypeName { get { return default(string); } }
        public System.Type Target { get { return default(System.Type); } set { } }
        public string TargetTypeName { get { return default(string); } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StackFrame
    {
        public const int OFFSET_UNKNOWN = -1;
        [System.Security.SecuritySafeCriticalAttribute]
        public StackFrame() { }
        [System.Security.SecurityCriticalAttribute]
        public StackFrame(bool fNeedFileInfo) { }
        public StackFrame(int skipFrames) { }
        [System.Security.SecurityCriticalAttribute]
        public StackFrame(int skipFrames, bool fNeedFileInfo) { }
        public StackFrame(string fileName, int lineNumber) { }
        public StackFrame(string fileName, int lineNumber, int colNumber) { }
        public virtual int GetFileColumnNumber() { return default(int); }
        public virtual int GetFileLineNumber() { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public virtual string GetFileName() { return default(string); }
        public virtual int GetILOffset() { return default(int); }
        public virtual System.Reflection.MethodBase GetMethod() { return default(System.Reflection.MethodBase); }
        public virtual int GetNativeOffset() { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StackTrace
    {
        public const int METHODS_TO_SKIP = 0;
        [System.Security.SecuritySafeCriticalAttribute]
        public StackTrace() { }
        [System.Security.SecurityCriticalAttribute]
        public StackTrace(bool fNeedFileInfo) { }
        public StackTrace(System.Diagnostics.StackFrame frame) { }
        public StackTrace(System.Exception e) { }
        [System.Security.SecurityCriticalAttribute]
        public StackTrace(System.Exception e, bool fNeedFileInfo) { }
        [System.Security.SecurityCriticalAttribute]
        public StackTrace(System.Exception e, int skipFrames) { }
        [System.Security.SecurityCriticalAttribute]
        public StackTrace(System.Exception e, int skipFrames, bool fNeedFileInfo) { }
        [System.Security.SecurityCriticalAttribute]
        public StackTrace(int skipFrames) { }
        [System.Security.SecurityCriticalAttribute]
        public StackTrace(int skipFrames, bool fNeedFileInfo) { }
        [System.ObsoleteAttribute("This constructor has been deprecated.  Please use a constructor that does not require a Thread parameter.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [System.Security.SecurityCriticalAttribute]
        public StackTrace(System.Threading.Thread targetThread, bool needFileInfo) { }
        public virtual int FrameCount { get { return default(int); } }
        public virtual System.Diagnostics.StackFrame GetFrame(int index) { return default(System.Diagnostics.StackFrame); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual System.Diagnostics.StackFrame[] GetFrames() { return default(System.Diagnostics.StackFrame[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
    }
}
namespace System.Diagnostics.CodeAnalysis
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited=false, AllowMultiple=true)]
    [System.Diagnostics.ConditionalAttribute("CODE_ANALYSIS")]
    public sealed partial class SuppressMessageAttribute : System.Attribute
    {
        public SuppressMessageAttribute(string category, string checkId) { }
        public string Category { get { return default(string); } }
        public string CheckId { get { return default(string); } }
        public string Justification { get { return default(string); } set { } }
        public string MessageId { get { return default(string); } set { } }
        public string Scope { get { return default(string); } set { } }
        public string Target { get { return default(string); } set { } }
    }
}
namespace System.Diagnostics.Contracts
{
    public static partial class Contract
    {
        public static event System.EventHandler<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailed { add { } remove { } }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        
        public static void Assert(bool condition) { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        
        public static void Assert(bool condition, string userMessage) { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        
        public static void Assume(bool condition) { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        
        public static void Assume(bool condition, string userMessage) { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void EndContractBlock() { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void Ensures(bool condition) { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void Ensures(bool condition, string userMessage) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification="Exception type used in tools.")]
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void EnsuresOnThrow<TException>(bool condition) where TException : System.Exception { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification="Exception type used in tools.")]
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void EnsuresOnThrow<TException>(bool condition, string userMessage) where TException : System.Exception { }
        
        public static bool Exists(int fromInclusive, int toExclusive, System.Predicate<int> predicate) { return default(bool); }
        
        public static bool Exists<T>(System.Collections.Generic.IEnumerable<T> collection, System.Predicate<T> predicate) { return default(bool); }
        
        public static bool ForAll(int fromInclusive, int toExclusive, System.Predicate<int> predicate) { return default(bool); }
        
        public static bool ForAll<T>(System.Collections.Generic.IEnumerable<T> collection, System.Predicate<T> predicate) { return default(bool); }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void Invariant(bool condition) { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void Invariant(bool condition, string userMessage) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId="value")]
        
        public static T OldValue<T>(T value) { return default(T); }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void Requires(bool condition) { }
        [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
        
        public static void Requires(bool condition, string userMessage) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId="condition")]
        
        public static void Requires<TException>(bool condition) where TException : System.Exception { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId="condition")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId="userMessage")]
        
        public static void Requires<TException>(bool condition, string userMessage) where TException : System.Exception { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification="Not intended to be called at runtime.")]
        
        public static T Result<T>() { return default(T); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId="0#", Justification="Not intended to be called at runtime.")]
        
        public static T ValueAtReturn<T>(out T value) { value = default(T); return default(T); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractAbbreviatorAttribute : System.Attribute
    {
        public ContractAbbreviatorAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractArgumentValidatorAttribute : System.Attribute
    {
        public ContractArgumentValidatorAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5124), AllowMultiple=false, Inherited=false)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public sealed partial class ContractClassAttribute : System.Attribute
    {
        public ContractClassAttribute(System.Type typeContainingContracts) { }
        public System.Type TypeContainingContracts { get { return default(System.Type); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractClassForAttribute : System.Attribute
    {
        public ContractClassForAttribute(System.Type typeContractsAreFor) { }
        public System.Type TypeContractsAreFor { get { return default(System.Type); } }
    }
    public sealed partial class ContractFailedEventArgs : System.EventArgs
    {
        
        public ContractFailedEventArgs(System.Diagnostics.Contracts.ContractFailureKind failureKind, string message, string condition, System.Exception originalException) { }
        public string Condition { get { return default(string); } }
        public System.Diagnostics.Contracts.ContractFailureKind FailureKind { get { return default(System.Diagnostics.Contracts.ContractFailureKind); } }
        public bool Handled { get { return default(bool); } }
        public string Message { get { return default(string); } }
        public System.Exception OriginalException { get { return default(System.Exception); } }
        public bool Unwind { get { return default(bool); } }
        [System.Security.SecurityCriticalAttribute]
        public void SetHandled() { }
        [System.Security.SecurityCriticalAttribute]
        public void SetUnwind() { }
    }
    public enum ContractFailureKind
    {
        Assert = 4,
        Assume = 5,
        Invariant = 3,
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="Postcondition")]
        Postcondition = 1,
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId="Postcondition")]
        PostconditionOnException = 2,
        Precondition = 0,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractInvariantMethodAttribute : System.Attribute
    {
        public ContractInvariantMethodAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true, Inherited=false)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractOptionAttribute : System.Attribute
    {
        public ContractOptionAttribute(string category, string setting, bool enabled) { }
        public ContractOptionAttribute(string category, string setting, string value) { }
        public string Category { get { return default(string); } }
        public bool Enabled { get { return default(bool); } }
        public string Setting { get { return default(string); } }
        public string Value { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Justification="Thank you very much, but we like the names we've defined for the accessors")]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractPublicPropertyNameAttribute : System.Attribute
    {
        public ContractPublicPropertyNameAttribute(string name) { }
        public string Name { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    public sealed partial class ContractReferenceAssemblyAttribute : System.Attribute
    {
        public ContractReferenceAssemblyAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(192), AllowMultiple=false, Inherited=true)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractRuntimeIgnoredAttribute : System.Attribute
    {
        public ContractRuntimeIgnoredAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(237))]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class ContractVerificationAttribute : System.Attribute
    {
        public ContractVerificationAttribute(bool value) { }
        public bool Value { get { return default(bool); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(6884), AllowMultiple=false, Inherited=true)]
    [System.Diagnostics.ConditionalAttribute("CONTRACTS_FULL")]
    public sealed partial class PureAttribute : System.Attribute
    {
        public PureAttribute() { }
    }
}
namespace System.Diagnostics.Contracts.Internal
{
    [System.ObsoleteAttribute("Use the ContractHelper class in the System.Runtime.CompilerServices namespace instead.")]
    public static partial class ContractHelper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        
        public static string RaiseContractFailedEvent(System.Diagnostics.Contracts.ContractFailureKind failureKind, string userMessage, string conditionText, System.Exception innerException) { return default(string); }
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        
        public static void TriggerFailure(System.Diagnostics.Contracts.ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, System.Exception innerException) { }
    }
}
namespace System.Diagnostics.SymbolStore
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISymbolDocumentWriter
    {
        void SetCheckSum(System.Guid algorithmId, byte[] checkSum);
        void SetSource(byte[] source);
    }
}
namespace System.Diagnostics.Tracing
{
    [System.FlagsAttribute]
    public enum EventActivityOptions
    {
        Detachable = 8,
        Disable = 2,
        None = 0,
        Recursive = 4,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class EventAttribute : System.Attribute
    {
        public EventAttribute(int eventId) { }
        public System.Diagnostics.Tracing.EventActivityOptions ActivityOptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventActivityOptions); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Diagnostics.Tracing.EventChannel Channel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventChannel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int EventId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
        public System.Diagnostics.Tracing.EventKeywords Keywords { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventKeywords); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Diagnostics.Tracing.EventLevel Level { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Diagnostics.Tracing.EventOpcode Opcode { get { return default(System.Diagnostics.Tracing.EventOpcode); } set { } }
        public System.Diagnostics.Tracing.EventTags Tags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventTags); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Diagnostics.Tracing.EventTask Task { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventTask); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public byte Version { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(byte); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1028:EnumStorageShouldBeInt32", Justification="Backwards compatibility")]

    public enum EventChannel : byte
    {
        Admin = (byte)16,
        Analytic = (byte)18,
        Debug = (byte)19,
        None = (byte)0,
        Operational = (byte)17,
    }
    public enum EventCommand
    {
        Disable = -3,
        Enable = -2,
        SendManifest = -1,
        Update = 0,
    }
    public partial class EventCommandEventArgs : System.EventArgs
    {
        internal EventCommandEventArgs() { }
        public System.Collections.Generic.IDictionary<string, string> Arguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<string, string>); } }
        public System.Diagnostics.Tracing.EventCommand Command { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventCommand); } }
        public bool DisableEvent(int eventId) { return default(bool); }
        public bool EnableEvent(int eventId) { return default(bool); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=false)]
    public partial class EventDataAttribute : System.Attribute
    {
        public EventDataAttribute() { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public partial class EventFieldAttribute : System.Attribute
    {
        public EventFieldAttribute() { }
        public System.Diagnostics.Tracing.EventFieldFormat Format { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventFieldFormat); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Diagnostics.Tracing.EventFieldTags Tags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.Tracing.EventFieldTags); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public enum EventFieldFormat
    {
        Boolean = 3,
        Default = 0,
        Hexadecimal = 4,
        HResult = 15,
        Json = 12,
        String = 2,
        Xml = 11,
    }
    [System.FlagsAttribute]
    public enum EventFieldTags
    {
        None = 0,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public partial class EventIgnoreAttribute : System.Attribute
    {
        public EventIgnoreAttribute() { }
    }
    [System.FlagsAttribute]
    public enum EventKeywords : long
    {
        All = (long)-1,
        AuditFailure = (long)4503599627370496,
        AuditSuccess = (long)9007199254740992,
        CorrelationHint = (long)4503599627370496,
        EventLogClassic = (long)36028797018963968,
        MicrosoftTelemetry = (long)562949953421312,
        None = (long)0,
        Sqm = (long)2251799813685248,
        WdiContext = (long)562949953421312,
        WdiDiagnostic = (long)1125899906842624,
    }
    public enum EventLevel
    {
        Critical = 1,
        Error = 2,
        Informational = 4,
        LogAlways = 0,
        Verbose = 5,
        Warning = 3,
    }
    public partial class EventListener : System.IDisposable
    {
        public EventListener() { }
        public void DisableEvents(System.Diagnostics.Tracing.EventSource eventSource) { }
        public virtual void Dispose() { }
        public void EnableEvents(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventLevel level) { }
        public void EnableEvents(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords matchAnyKeyword) { }
        public void EnableEvents(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords matchAnyKeyword, System.Collections.Generic.IDictionary<string, string> arguments) { }
        public static int EventSourceIndex(System.Diagnostics.Tracing.EventSource eventSource) { return default(int); }
        protected internal virtual void OnEventSourceCreated(System.Diagnostics.Tracing.EventSource eventSource) { }
        protected internal virtual void OnEventWritten(System.Diagnostics.Tracing.EventWrittenEventArgs eventData) { }
    }
    [System.FlagsAttribute]
    public enum EventManifestOptions
    {
        AllCultures = 2,
        AllowEventSourceOverride = 8,
        None = 0,
        OnlyIfNeededForRegistration = 4,
        Strict = 1,
    }

    public enum EventOpcode
    {
        DataCollectionStart = 3,
        DataCollectionStop = 4,
        Extension = 5,
        Info = 0,
        Receive = 240,
        Reply = 6,
        Resume = 7,
        Send = 9,
        Start = 1,
        Stop = 2,
        Suspend = 8,
    }
    public partial class EventSource : System.IDisposable
    {
        protected EventSource() { }
        protected EventSource(bool throwOnEventWriteErrors) { }
        protected EventSource(System.Diagnostics.Tracing.EventSourceSettings settings) { }
        protected EventSource(System.Diagnostics.Tracing.EventSourceSettings settings, params string[] traits) { }
        public EventSource(string eventSourceName) { }
        public EventSource(string eventSourceName, System.Diagnostics.Tracing.EventSourceSettings config) { }
        public EventSource(string eventSourceName, System.Diagnostics.Tracing.EventSourceSettings config, params string[] traits) { }
        public System.Exception ConstructionException { get { return default(System.Exception); } }
        public static System.Guid CurrentThreadActivityId { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Guid); } }
        public System.Guid Guid { get { return default(System.Guid); } }
        public string Name { get { return default(string); } }
        public System.Diagnostics.Tracing.EventSourceSettings Settings { get { return default(System.Diagnostics.Tracing.EventSourceSettings); } }
        public event System.EventHandler<System.Diagnostics.Tracing.EventCommandEventArgs> EventCommandExecuted { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~EventSource() { }
        public static string GenerateManifest(System.Type eventSourceType, string assemblyPathToIncludeInManifest) { return default(string); }
        public static string GenerateManifest(System.Type eventSourceType, string assemblyPathToIncludeInManifest, System.Diagnostics.Tracing.EventManifestOptions flags) { return default(string); }
        public static System.Guid GetGuid(System.Type eventSourceType) { return default(System.Guid); }
        public static string GetName(System.Type eventSourceType) { return default(string); }
        public static System.Collections.Generic.IEnumerable<System.Diagnostics.Tracing.EventSource> GetSources() { return default(System.Collections.Generic.IEnumerable<System.Diagnostics.Tracing.EventSource>); }
        public string GetTrait(string key) { return default(string); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        public bool IsEnabled() { return default(bool); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        public bool IsEnabled(System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords keywords) { return default(bool); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        public bool IsEnabled(System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords keywords, System.Diagnostics.Tracing.EventChannel channel) { return default(bool); }
        protected virtual void OnEventCommand(System.Diagnostics.Tracing.EventCommandEventArgs command) { }
        public static void SendCommand(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventCommand command, System.Collections.Generic.IDictionary<string, string> commandArguments) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void SetCurrentThreadActivityId(System.Guid activityId) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void SetCurrentThreadActivityId(System.Guid activityId, out System.Guid oldActivityThatWillContinue) { oldActivityThatWillContinue = default(System.Guid); }
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(string eventName) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(string eventName, System.Diagnostics.Tracing.EventSourceOptions options) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write<T>(string eventName, T data) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write<T>(string eventName, System.Diagnostics.Tracing.EventSourceOptions options, T data) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write<T>(string eventName, ref System.Diagnostics.Tracing.EventSourceOptions options, ref T data) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write<T>(string eventName, ref System.Diagnostics.Tracing.EventSourceOptions options, ref System.Guid activityId, ref System.Guid relatedActivityId, ref T data) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, byte[] arg1) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, int arg1) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, int arg1, int arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, int arg1, string arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, long arg1) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, long arg1, byte[] arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, long arg1, long arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, long arg1, long arg2, long arg3) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, long arg1, string arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, params object[] args) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, string arg1) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, string arg1, int arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, string arg1, int arg2, int arg3) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, string arg1, long arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, string arg1, string arg2) { }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Concurrency", "CA8001", Justification="This does not need to be correct when racing with other threads")]
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        protected unsafe void WriteEventCore(int eventId, int eventDataCount, System.Diagnostics.Tracing.EventSource.EventData* data) { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected void WriteEventWithRelatedActivityId(int eventId, System.Guid relatedActivityId, params object[] args) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        protected unsafe void WriteEventWithRelatedActivityIdCore(int eventId, System.Guid* relatedActivityId, int eventDataCount, System.Diagnostics.Tracing.EventSource.EventData* data) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        protected internal partial struct EventData
        {
            public System.IntPtr DataPointer { get { return default(System.IntPtr); } set { } }
            public int Size { get { return default(int); } set { } }
        }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    public sealed partial class EventSourceAttribute : System.Attribute
    {
        public EventSourceAttribute() { }
        public string Guid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LocalizationResources { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class EventSourceException : System.Exception
    {
        public EventSourceException() { }
        public EventSourceException(string message) { }
        public EventSourceException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EventSourceOptions
    {
        public System.Diagnostics.Tracing.EventActivityOptions ActivityOptions { get { return default(System.Diagnostics.Tracing.EventActivityOptions); } set { } }
        public System.Diagnostics.Tracing.EventKeywords Keywords { get { return default(System.Diagnostics.Tracing.EventKeywords); } set { } }
        public System.Diagnostics.Tracing.EventLevel Level { get { return default(System.Diagnostics.Tracing.EventLevel); } set { } }
        public System.Diagnostics.Tracing.EventOpcode Opcode { get { return default(System.Diagnostics.Tracing.EventOpcode); } set { } }
        public System.Diagnostics.Tracing.EventTags Tags { get { return default(System.Diagnostics.Tracing.EventTags); } set { } }
    }
    [System.FlagsAttribute]
    public enum EventSourceSettings
    {
        Default = 0,
        EtwManifestEventFormat = 4,
        EtwSelfDescribingEventFormat = 8,
        ThrowOnEventWriteErrors = 1,
    }
    [System.FlagsAttribute]
    public enum EventTags
    {
        None = 0,
    }

    public enum EventTask
    {
        None = 0,
    }
    public partial class EventWrittenEventArgs : System.EventArgs
    {
        internal EventWrittenEventArgs() { }
        public System.Guid ActivityId { [System.Security.SecurityCriticalAttribute]get { return default(System.Guid); } }
        public System.Diagnostics.Tracing.EventChannel Channel { get { return default(System.Diagnostics.Tracing.EventChannel); } }
        public int EventId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
        public string EventName { get { return default(string); } }
        public System.Diagnostics.Tracing.EventSource EventSource { get { return default(System.Diagnostics.Tracing.EventSource); } }
        public System.Diagnostics.Tracing.EventKeywords Keywords { get { return default(System.Diagnostics.Tracing.EventKeywords); } }
        public System.Diagnostics.Tracing.EventLevel Level { get { return default(System.Diagnostics.Tracing.EventLevel); } }
        public string Message { get { return default(string); } }
        public System.Diagnostics.Tracing.EventOpcode Opcode { get { return default(System.Diagnostics.Tracing.EventOpcode); } }
        public System.Collections.ObjectModel.ReadOnlyCollection<object> Payload { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<object>); } }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> PayloadNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<string>); } }
        public System.Guid RelatedActivityId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute, System.Security.SecurityCriticalAttribute]get { return default(System.Guid); } }
        public System.Diagnostics.Tracing.EventTags Tags { get { return default(System.Diagnostics.Tracing.EventTags); } }
        public System.Diagnostics.Tracing.EventTask Task { get { return default(System.Diagnostics.Tracing.EventTask); } }
        public byte Version { get { return default(byte); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class NonEventAttribute : System.Attribute
    {
        public NonEventAttribute() { }
    }
}
namespace System.Globalization
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Calendar
    {
        public const int CurrentEra = 0;
        protected Calendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        protected virtual int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public abstract int[] Eras { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public bool IsReadOnly { get { return default(bool); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public virtual int TwoDigitYearMax { get { return default(int); } set { } }
        public virtual System.DateTime AddDays(System.DateTime time, int days) { return default(System.DateTime); }
        public virtual System.DateTime AddHours(System.DateTime time, int hours) { return default(System.DateTime); }
        public virtual System.DateTime AddMilliseconds(System.DateTime time, double milliseconds) { return default(System.DateTime); }
        public virtual System.DateTime AddMinutes(System.DateTime time, int minutes) { return default(System.DateTime); }
        public abstract System.DateTime AddMonths(System.DateTime time, int months);
        public virtual System.DateTime AddSeconds(System.DateTime time, int seconds) { return default(System.DateTime); }
        public virtual System.DateTime AddWeeks(System.DateTime time, int weeks) { return default(System.DateTime); }
        public abstract System.DateTime AddYears(System.DateTime time, int years);
        public abstract int GetDayOfMonth(System.DateTime time);
        public abstract System.DayOfWeek GetDayOfWeek(System.DateTime time);
        public abstract int GetDayOfYear(System.DateTime time);
        public virtual int GetDaysInMonth(int year, int month) { return default(int); }
        public abstract int GetDaysInMonth(int year, int month, int era);
        public virtual int GetDaysInYear(int year) { return default(int); }
        public abstract int GetDaysInYear(int year, int era);
        public abstract int GetEra(System.DateTime time);
        public virtual int GetHour(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual int GetLeapMonth(int year, int era) { return default(int); }
        public virtual double GetMilliseconds(System.DateTime time) { return default(double); }
        public virtual int GetMinute(System.DateTime time) { return default(int); }
        public abstract int GetMonth(System.DateTime time);
        public virtual int GetMonthsInYear(int year) { return default(int); }
        public abstract int GetMonthsInYear(int year, int era);
        public virtual int GetSecond(System.DateTime time) { return default(int); }
        public virtual int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public abstract int GetYear(System.DateTime time);
        public virtual bool IsLeapDay(int year, int month, int day) { return default(bool); }
        public abstract bool IsLeapDay(int year, int month, int day, int era);
        public virtual bool IsLeapMonth(int year, int month) { return default(bool); }
        public abstract bool IsLeapMonth(int year, int month, int era);
        public virtual bool IsLeapYear(int year) { return default(bool); }
        public abstract bool IsLeapYear(int year, int era);
        public virtual System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { return default(System.DateTime); }
        public abstract System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
        public virtual int ToFourDigitYear(int year) { return default(int); }
    }
#if FEATURE_COREFX_GLOBALIZATION
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CalendarAlgorithmType
    {
        LunarCalendar = 2,
        LunisolarCalendar = 3,
        SolarCalendar = 1,
        Unknown = 0,
    }
#endif
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CalendarWeekRule
    {
        FirstDay = 0,
        FirstFourDayWeek = 2,
        FirstFullWeek = 1,
    }
    public static partial class CharUnicodeInfo
    {
        public static double GetNumericValue(char ch) { return default(double); }
        public static double GetNumericValue(string s, int index) { return default(double); }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(char ch) { return default(System.Globalization.UnicodeCategory); }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(string s, int index) { return default(System.Globalization.UnicodeCategory); }
    }
    public partial class ChineseLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public const int ChineseEra = 1;
        public ChineseLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetEra(System.DateTime time) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CompareInfo
    {
        internal CompareInfo() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual string Name { get { return default(string); } }
        public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int Compare(string string1, int offset1, string string2, int offset2) { return default(int); }
        public virtual int Compare(string string1, int offset1, string string2, int offset2, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int Compare(string string1, string string2) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual int Compare(string string1, string string2, System.Globalization.CompareOptions options) { return default(int); }
        public override bool Equals(object value) { return default(bool); }
        public static System.Globalization.CompareInfo GetCompareInfo(string name) { return default(System.Globalization.CompareInfo); }
        public override int GetHashCode() { return default(int); }
        public virtual int GetHashCode(string source, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int IndexOf(string source, char value) { return default(int); }
        public virtual int IndexOf(string source, char value, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int IndexOf(string source, char value, int startIndex, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int IndexOf(string source, char value, int startIndex, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual int IndexOf(string source, char value, int startIndex, int count, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int IndexOf(string source, string value) { return default(int); }
        public virtual int IndexOf(string source, string value, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int IndexOf(string source, string value, int startIndex, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int IndexOf(string source, string value, int startIndex, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual int IndexOf(string source, string value, int startIndex, int count, System.Globalization.CompareOptions options) { return default(int); }
        public virtual bool IsPrefix(string source, string prefix) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual bool IsPrefix(string source, string prefix, System.Globalization.CompareOptions options) { return default(bool); }
        public virtual bool IsSuffix(string source, string suffix) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual bool IsSuffix(string source, string suffix, System.Globalization.CompareOptions options) { return default(bool); }
        public virtual int LastIndexOf(string source, char value) { return default(int); }
        public virtual int LastIndexOf(string source, char value, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int LastIndexOf(string source, char value, int startIndex, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int LastIndexOf(string source, char value, int startIndex, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual int LastIndexOf(string source, char value, int startIndex, int count, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int LastIndexOf(string source, string value) { return default(int); }
        public virtual int LastIndexOf(string source, string value, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int LastIndexOf(string source, string value, int startIndex, System.Globalization.CompareOptions options) { return default(int); }
        public virtual int LastIndexOf(string source, string value, int startIndex, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual int LastIndexOf(string source, string value, int startIndex, int count, System.Globalization.CompareOptions options) { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CompareOptions
    {
        IgnoreCase = 1,
        IgnoreKanaType = 8,
        IgnoreNonSpace = 2,
        IgnoreSymbols = 4,
        IgnoreWidth = 16,
        None = 0,
        Ordinal = 1073741824,
        OrdinalIgnoreCase = 268435456,
        StringSort = 536870912,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CultureInfo : System.IFormatProvider
    {
        public CultureInfo(string name) { }
        public virtual System.Globalization.Calendar Calendar { get { return default(System.Globalization.Calendar); } }
        public virtual System.Globalization.CompareInfo CompareInfo { get { return default(System.Globalization.CompareInfo); } }
        public static System.Globalization.CultureInfo CurrentCulture { get { return default(System.Globalization.CultureInfo); } set { } }
        public static System.Globalization.CultureInfo CurrentUICulture { get { return default(System.Globalization.CultureInfo); } set { } }
        public virtual System.Globalization.DateTimeFormatInfo DateTimeFormat { get { return default(System.Globalization.DateTimeFormatInfo); } set { } }
        public static System.Globalization.CultureInfo DefaultThreadCurrentCulture { get { return default(System.Globalization.CultureInfo); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public static System.Globalization.CultureInfo DefaultThreadCurrentUICulture { get { return default(System.Globalization.CultureInfo); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public virtual string DisplayName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual string EnglishName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public static System.Globalization.CultureInfo InvariantCulture { get { return default(System.Globalization.CultureInfo); } }
        public virtual bool IsNeutralCulture { get { return default(bool); } }
        public bool IsReadOnly { get { return default(bool); } }
        public virtual string Name { get { return default(string); } }
        public virtual string NativeName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual System.Globalization.NumberFormatInfo NumberFormat { get { return default(System.Globalization.NumberFormatInfo); } set { } }
        public virtual System.Globalization.Calendar[] OptionalCalendars { get { return default(System.Globalization.Calendar[]); } }
        public virtual System.Globalization.CultureInfo Parent { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Globalization.CultureInfo); } }
        public virtual System.Globalization.TextInfo TextInfo { get { return default(System.Globalization.TextInfo); } }
        public virtual string TwoLetterISOLanguageName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual object Clone() { return default(object); }
        public override bool Equals(object value) { return default(bool); }
        public virtual object GetFormat(System.Type formatType) { return default(object); }
        public override int GetHashCode() { return default(int); }
        public static System.Globalization.CultureInfo ReadOnly(System.Globalization.CultureInfo ci) { return default(System.Globalization.CultureInfo); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CultureNotFoundException : System.ArgumentException
    {
        public CultureNotFoundException() { }
        public CultureNotFoundException(string message) { }
        public CultureNotFoundException(string message, System.Exception innerException) { }
        public CultureNotFoundException(string paramName, string message) { }
        public CultureNotFoundException(string message, string invalidCultureName, System.Exception innerException) { }
        public CultureNotFoundException(string paramName, string invalidCultureName, string message) { }
        public virtual string InvalidCultureName { get { return default(string); } }
        public override string Message { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DateTimeFormatInfo : System.IFormatProvider
    {
        public DateTimeFormatInfo() { }
        public string[] AbbreviatedDayNames { get { return default(string[]); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] AbbreviatedMonthGenitiveNames { get { return default(string[]); } set { } }
        public string[] AbbreviatedMonthNames { get { return default(string[]); } set { } }
        public string AMDesignator { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } set { } }
        public System.Globalization.Calendar Calendar { get { return default(System.Globalization.Calendar); } set { } }
        public System.Globalization.CalendarWeekRule CalendarWeekRule { get { return default(System.Globalization.CalendarWeekRule); } set { } }
        public static System.Globalization.DateTimeFormatInfo CurrentInfo { get { return default(System.Globalization.DateTimeFormatInfo); } }
        public string[] DayNames { get { return default(string[]); } set { } }
        public System.DayOfWeek FirstDayOfWeek { get { return default(System.DayOfWeek); } set { } }
        public string FullDateTimePattern { get { return default(string); } set { } }
        public static System.Globalization.DateTimeFormatInfo InvariantInfo { get { return default(System.Globalization.DateTimeFormatInfo); } }
        public bool IsReadOnly { get { return default(bool); } }
        public string LongDatePattern { get { return default(string); } set { } }
        public string LongTimePattern { get { return default(string); } set { } }
        public string MonthDayPattern { get { return default(string); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] MonthGenitiveNames { get { return default(string[]); } set { } }
        public string[] MonthNames { get { return default(string[]); } set { } }
        public string PMDesignator { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } set { } }
        public string RFC1123Pattern { get { return default(string); } }
        public string ShortDatePattern { get { return default(string); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] ShortestDayNames { get { return default(string[]); } set { } }
        public string ShortTimePattern { get { return default(string); } set { } }
        public string SortableDateTimePattern { get { return default(string); } }
        public string UniversalSortableDateTimePattern { get { return default(string); } }
        public string YearMonthPattern { get { return default(string); } set { } }
        public object Clone() { return default(object); }
        public string GetAbbreviatedDayName(System.DayOfWeek dayofweek) { return default(string); }
        public string GetAbbreviatedEraName(int era) { return default(string); }
        public string GetAbbreviatedMonthName(int month) { return default(string); }
        public string GetDayName(System.DayOfWeek dayofweek) { return default(string); }
        public int GetEra(string eraName) { return default(int); }
        public string GetEraName(int era) { return default(string); }
        public object GetFormat(System.Type formatType) { return default(object); }
        public static System.Globalization.DateTimeFormatInfo GetInstance(System.IFormatProvider provider) { return default(System.Globalization.DateTimeFormatInfo); }
        public string GetMonthName(int month) { return default(string); }
        public static System.Globalization.DateTimeFormatInfo ReadOnly(System.Globalization.DateTimeFormatInfo dtfi) { return default(System.Globalization.DateTimeFormatInfo); }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DateTimeStyles
    {
        AdjustToUniversal = 16,
        AllowInnerWhite = 4,
        AllowLeadingWhite = 1,
        AllowTrailingWhite = 2,
        AllowWhiteSpaces = 7,
        AssumeLocal = 32,
        AssumeUniversal = 64,
        NoCurrentDateDefault = 8,
        None = 0,
        RoundtripKind = 128,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class EastAsianLunisolarCalendar : System.Globalization.Calendar
    {
        internal EastAsianLunisolarCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public int GetCelestialStem(int sexagenaryYear) { return default(int); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public virtual int GetSexagenaryYear(System.DateTime time) { return default(int); }
        public int GetTerrestrialBranch(int sexagenaryYear) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class GregorianCalendar : System.Globalization.Calendar
    {
        public const int ADEra = 1;
        public GregorianCalendar() { }
        public GregorianCalendar(System.Globalization.GregorianCalendarTypes type) { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public virtual System.Globalization.GregorianCalendarTypes CalendarType { get { return default(System.Globalization.GregorianCalendarTypes); } set { } }
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum GregorianCalendarTypes
    {
        Arabic = 10,
        Localized = 1,
        MiddleEastFrench = 9,
        TransliteratedEnglish = 11,
        TransliteratedFrench = 12,
        USEnglish = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HebrewCalendar : System.Globalization.Calendar
    {
        public HebrewCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HijriCalendar : System.Globalization.Calendar
    {
        public HijriCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public int HijriAdjustment { [System.Security.SecuritySafeCriticalAttribute]get { return default(int); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class JapaneseCalendar : System.Globalization.Calendar
    {
        public JapaneseCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Contracts", "CC1055")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    public partial class JapaneseLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public const int JapaneseEra = 1;
        public JapaneseLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int GetEra(System.DateTime time) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class JulianCalendar : System.Globalization.Calendar
    {
        public static readonly int JulianEra;
        public JulianCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class KoreanCalendar : System.Globalization.Calendar
    {
        public const int KoreanEra = 1;
        public KoreanCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Contracts", "CC1055")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    public partial class KoreanLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public const int GregorianEra = 1;
        public KoreanLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int GetEra(System.DateTime time) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class NumberFormatInfo : System.IFormatProvider
    {
        public NumberFormatInfo() { }
        public int CurrencyDecimalDigits { get { return default(int); } set { } }
        public string CurrencyDecimalSeparator { get { return default(string); } set { } }
        public string CurrencyGroupSeparator { get { return default(string); } set { } }
        public int[] CurrencyGroupSizes { get { return default(int[]); } set { } }
        public int CurrencyNegativePattern { get { return default(int); } set { } }
        public int CurrencyPositivePattern { get { return default(int); } set { } }
        public string CurrencySymbol { get { return default(string); } set { } }
        public static System.Globalization.NumberFormatInfo CurrentInfo { get { return default(System.Globalization.NumberFormatInfo); } }
        public static System.Globalization.NumberFormatInfo InvariantInfo { get { return default(System.Globalization.NumberFormatInfo); } }
        public bool IsReadOnly { get { return default(bool); } }
        public string NaNSymbol { get { return default(string); } set { } }
        public string NegativeInfinitySymbol { get { return default(string); } set { } }
        public string NegativeSign { get { return default(string); } set { } }
        public int NumberDecimalDigits { get { return default(int); } set { } }
        public string NumberDecimalSeparator { get { return default(string); } set { } }
        public string NumberGroupSeparator { get { return default(string); } set { } }
        public int[] NumberGroupSizes { get { return default(int[]); } set { } }
        public int NumberNegativePattern { get { return default(int); } set { } }
        public int PercentDecimalDigits { get { return default(int); } set { } }
        public string PercentDecimalSeparator { get { return default(string); } set { } }
        public string PercentGroupSeparator { get { return default(string); } set { } }
        public int[] PercentGroupSizes { get { return default(int[]); } set { } }
        public int PercentNegativePattern { get { return default(int); } set { } }
        public int PercentPositivePattern { get { return default(int); } set { } }
        public string PercentSymbol { get { return default(string); } set { } }
        public string PerMilleSymbol { get { return default(string); } set { } }
        public string PositiveInfinitySymbol { get { return default(string); } set { } }
        public string PositiveSign { get { return default(string); } set { } }
        public object Clone() { return default(object); }
        public object GetFormat(System.Type formatType) { return default(object); }
        public static System.Globalization.NumberFormatInfo GetInstance(System.IFormatProvider formatProvider) { return default(System.Globalization.NumberFormatInfo); }
        public static System.Globalization.NumberFormatInfo ReadOnly(System.Globalization.NumberFormatInfo nfi) { return default(System.Globalization.NumberFormatInfo); }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum NumberStyles
    {
        AllowCurrencySymbol = 256,
        AllowDecimalPoint = 32,
        AllowExponent = 128,
        AllowHexSpecifier = 512,
        AllowLeadingSign = 4,
        AllowLeadingWhite = 1,
        AllowParentheses = 16,
        AllowThousands = 64,
        AllowTrailingSign = 8,
        AllowTrailingWhite = 2,
        Any = 511,
        Currency = 383,
        Float = 167,
        HexNumber = 515,
        Integer = 7,
        None = 0,
        Number = 111,
    }
    public partial class PersianCalendar : System.Globalization.Calendar
    {
        public static readonly int PersianEra;
        public PersianCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RegionInfo
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public RegionInfo(string name) { }
        public virtual string CurrencySymbol { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public static System.Globalization.RegionInfo CurrentRegion { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Globalization.RegionInfo); } }
        public virtual string DisplayName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual string EnglishName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual bool IsMetric { get { return default(bool); } }
        public virtual string ISOCurrencySymbol { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual string Name { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual string NativeName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public virtual string TwoLetterISORegionName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StringInfo
    {
        public StringInfo() { }
        public StringInfo(string value) { }
        public int LengthInTextElements { get { return default(int); } }
        public string String { get { return default(string); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object value) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public static string GetNextTextElement(string str) { return default(string); }
        public static string GetNextTextElement(string str, int index) { return default(string); }
        public static System.Globalization.TextElementEnumerator GetTextElementEnumerator(string str) { return default(System.Globalization.TextElementEnumerator); }
        public static System.Globalization.TextElementEnumerator GetTextElementEnumerator(string str, int index) { return default(System.Globalization.TextElementEnumerator); }
        public static int[] ParseCombiningCharacters(string str) { return default(int[]); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TaiwanCalendar : System.Globalization.Calendar
    {
        public TaiwanCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Contracts", "CC1055")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    public partial class TaiwanLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public TaiwanLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int GetEra(System.DateTime time) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TextElementEnumerator : System.Collections.IEnumerator
    {
        internal TextElementEnumerator() { }
        public object Current { get { return default(object); } }
        public int ElementIndex { get { return default(int); } }
        public string GetTextElement() { return default(string); }
        public bool MoveNext() { return default(bool); }
        public void Reset() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TextInfo
    {
        internal TextInfo() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string CultureName { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public bool IsReadOnly { get { return default(bool); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public bool IsRightToLeft { get { return default(bool); } }
        public virtual string ListSeparator { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } [System.Runtime.InteropServices.ComVisibleAttribute(false)]set { } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual char ToLower(char c) { return default(char); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual string ToLower(string str) { return default(string); }
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual char ToUpper(char c) { return default(char); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual string ToUpper(string str) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ThaiBuddhistCalendar : System.Globalization.Calendar
    {
        public const int ThaiBuddhistEra = 1;
        public ThaiBuddhistCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Contracts", "CC1055")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.FlagsAttribute]
    public enum TimeSpanStyles
    {
        AssumeNegative = 1,
        None = 0,
    }
    public partial class UmAlQuraCalendar : System.Globalization.Calendar
    {
        public UmAlQuraCalendar() { }
#if FEATURE_COREFX_GLOBALIZATION 
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
#endif
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum UnicodeCategory
    {
        ClosePunctuation = 21,
        ConnectorPunctuation = 18,
        Control = 14,
        CurrencySymbol = 26,
        DashPunctuation = 19,
        DecimalDigitNumber = 8,
        EnclosingMark = 7,
        FinalQuotePunctuation = 23,
        Format = 15,
        InitialQuotePunctuation = 22,
        LetterNumber = 9,
        LineSeparator = 12,
        LowercaseLetter = 1,
        MathSymbol = 25,
        ModifierLetter = 3,
        ModifierSymbol = 27,
        NonSpacingMark = 5,
        OpenPunctuation = 20,
        OtherLetter = 4,
        OtherNotAssigned = 29,
        OtherNumber = 10,
        OtherPunctuation = 24,
        OtherSymbol = 28,
        ParagraphSeparator = 13,
        PrivateUse = 17,
        SpaceSeparator = 11,
        SpacingCombiningMark = 6,
        Surrogate = 16,
        TitlecaseLetter = 2,
        UppercaseLetter = 0,
    }
}
namespace System.IO
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BinaryReader : System.IDisposable
    {
        public BinaryReader(System.IO.Stream input) { }
        public BinaryReader(System.IO.Stream input, System.Text.Encoding encoding) { }
        public BinaryReader(System.IO.Stream input, System.Text.Encoding encoding, bool leaveOpen) { }
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected virtual void FillBuffer(int numBytes) { }
        public virtual int PeekChar() { return default(int); }
        public virtual int Read() { return default(int); }
        public virtual int Read(byte[] buffer, int index, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual int Read(char[] buffer, int index, int count) { return default(int); }
        protected internal int Read7BitEncodedInt() { return default(int); }
        public virtual bool ReadBoolean() { return default(bool); }
        public virtual byte ReadByte() { return default(byte); }
        public virtual byte[] ReadBytes(int count) { return default(byte[]); }
        public virtual char ReadChar() { return default(char); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual char[] ReadChars(int count) { return default(char[]); }
        public virtual decimal ReadDecimal() { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual double ReadDouble() { return default(double); }
        public virtual short ReadInt16() { return default(short); }
        public virtual int ReadInt32() { return default(int); }
        public virtual long ReadInt64() { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public virtual sbyte ReadSByte() { return default(sbyte); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual float ReadSingle() { return default(float); }
        public virtual string ReadString() { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public virtual ushort ReadUInt16() { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public virtual uint ReadUInt32() { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public virtual ulong ReadUInt64() { return default(ulong); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BinaryWriter : System.IDisposable
    {
        public static readonly System.IO.BinaryWriter Null;
        protected System.IO.Stream OutStream;
        protected BinaryWriter() { }
        public BinaryWriter(System.IO.Stream output) { }
        public BinaryWriter(System.IO.Stream output, System.Text.Encoding encoding) { }
        public BinaryWriter(System.IO.Stream output, System.Text.Encoding encoding, bool leaveOpen) { }
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual void Flush() { }
        public virtual long Seek(int offset, System.IO.SeekOrigin origin) { return default(long); }
        public virtual void Write(bool value) { }
        public virtual void Write(byte value) { }
        public virtual void Write(byte[] buffer) { }
        public virtual void Write(byte[] buffer, int index, int count) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Write(char ch) { }
        public virtual void Write(char[] chars) { }
        public virtual void Write(char[] chars, int index, int count) { }
        public virtual void Write(decimal value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Write(double value) { }
        public virtual void Write(short value) { }
        public virtual void Write(int value) { }
        public virtual void Write(long value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(sbyte value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Write(float value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Write(string value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ulong value) { }
        protected void Write7BitEncodedInt(int value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DirectoryNotFoundException : System.IO.IOException
    {
        public DirectoryNotFoundException() { }
        public DirectoryNotFoundException(string message) { }
        public DirectoryNotFoundException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EndOfStreamException : System.IO.IOException
    {
        public EndOfStreamException() { }
        public EndOfStreamException(string message) { }
        public EndOfStreamException(string message, System.Exception innerException) { }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FileAccess
    {
        Read = 1,
        ReadWrite = 3,
        Write = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FileLoadException : System.IO.IOException
    {
        public FileLoadException() { }
        public FileLoadException(string message) { }
        public FileLoadException(string message, System.Exception inner) { }
        public FileLoadException(string message, string fileName) { }
        public FileLoadException(string message, string fileName, System.Exception inner) { }
        public string FileName { get { return default(string); } }
        public override string Message { get { return default(string); } }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FileNotFoundException : System.IO.IOException
    {
        public FileNotFoundException() { }
        public FileNotFoundException(string message) { }
        public FileNotFoundException(string message, System.Exception innerException) { }
        public FileNotFoundException(string message, string fileName) { }
        public FileNotFoundException(string message, string fileName, System.Exception innerException) { }
        public string FileName { get { return default(string); } }
        public override string Message { get { return default(string); } }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class IOException : System.SystemException
    {
        public IOException() { }
        public IOException(string message) { }
        public IOException(string message, System.Exception innerException) { }
        public IOException(string message, int hresult) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MemoryStream : System.IO.Stream
    {
        public MemoryStream() { }
        public MemoryStream(byte[] buffer) { }
        public MemoryStream(byte[] buffer, bool writable) { }
        public MemoryStream(byte[] buffer, int index, int count) { }
        public MemoryStream(byte[] buffer, int index, int count, bool writable) { }
        public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }
        public MemoryStream(int capacity) { }
        public override bool CanRead { get { return default(bool); } }
        public override bool CanSeek { get { return default(bool); } }
        public override bool CanWrite { get { return default(bool); } }
        public virtual int Capacity { get { return default(int); } set { } }
        public override long Length { get { return default(long); } }
        public override long Position { get { return default(long); } set { } }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public virtual byte[] GetBuffer() { return default(byte[]); }
        public override int Read(byte[] buffer, int offset, int count) { buffer = default(byte[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        public override int ReadByte() { return default(int); }
        public override long Seek(long offset, System.IO.SeekOrigin loc) { return default(long); }
        public override void SetLength(long value) { }
        public virtual byte[] ToArray() { return default(byte[]); }
        public virtual bool TryGetBuffer(out System.ArraySegment<byte> buffer) { buffer = default(System.ArraySegment<byte>); return default(bool); }
        public override void Write(byte[] buffer, int offset, int count) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public override void WriteByte(byte value) { }
        public virtual void WriteTo(System.IO.Stream stream) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class Path
    {
        public static readonly char AltDirectorySeparatorChar;
        public static readonly char DirectorySeparatorChar;
        public static readonly char PathSeparator;
        public static readonly char VolumeSeparatorChar;
        public static string ChangeExtension(string path, string extension) { return default(string); }
        public static string Combine(string path1, string path2) { return default(string); }
        public static string Combine(string path1, string path2, string path3) { return default(string); }
        public static string Combine(params string[] paths) { return default(string); }
        public static string GetDirectoryName(string path) { return default(string); }
        public static string GetExtension(string path) { return default(string); }
        public static string GetFileName(string path) { return default(string); }
        public static string GetFileNameWithoutExtension(string path) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string GetFullPath(string path) { return default(string); }
        public static char[] GetInvalidFileNameChars() { return default(char[]); }
        public static char[] GetInvalidPathChars() { return default(char[]); }
        public static string GetPathRoot(string path) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string GetRandomFileName() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string GetTempFileName() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string GetTempPath() { return default(string); }
        public static bool HasExtension(string path) { return default(bool); }
        public static bool IsPathRooted(string path) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PathTooLongException : System.IO.IOException
    {
        public PathTooLongException() { }
        public PathTooLongException(string message) { }
        public PathTooLongException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SeekOrigin
    {
        Begin = 0,
        Current = 1,
        End = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Stream : System.IDisposable
    {
        public static readonly System.IO.Stream Null;
        protected Stream() { }
        public abstract bool CanRead { get; }
        public abstract bool CanSeek { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual bool CanTimeout { get { return default(bool); } }
        public abstract bool CanWrite { get; }
        public abstract long Length { get; }
        public abstract long Position { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual int ReadTimeout { get { return default(int); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual int WriteTimeout { get { return default(int); } set { } }
        
        public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        
        public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public virtual void Close() { }
        public void CopyTo(System.IO.Stream destination) { }
        public void CopyTo(System.IO.Stream destination, int bufferSize) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual int EndRead(System.IAsyncResult asyncResult) { return default(int); }
        public virtual void EndWrite(System.IAsyncResult asyncResult) { }
        public abstract void Flush();
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public abstract int Read(byte[] buffer, int offset, int count);
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count) { return default(System.Threading.Tasks.Task<int>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        public virtual int ReadByte() { return default(int); }
        public abstract long Seek(long offset, System.IO.SeekOrigin origin);
        public abstract void SetLength(long value);
        public abstract void Write(byte[] buffer, int offset, int count);
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public virtual void WriteByte(byte value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StreamReader : System.IO.TextReader
    {
        public static readonly new System.IO.StreamReader Null;
        public StreamReader(System.IO.Stream stream) { }
        public StreamReader(System.IO.Stream stream, bool detectEncodingFromByteOrderMarks) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }
        public StreamReader(string path) { }
        public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }
        public StreamReader(string path, System.Text.Encoding encoding) { }
        public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        public virtual System.Text.Encoding CurrentEncoding { get { return default(System.Text.Encoding); } }
        public bool EndOfStream { get { return default(bool); } }
        public override void Close() { }
        public void DiscardBufferedData() { }
        protected override void Dispose(bool disposing) { }
        public override int Peek() { return default(int); }
        public override int Read() { return default(int); }
        public override int Read(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        public override int ReadBlock(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        public override string ReadLine() { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task<string> ReadLineAsync() { return default(System.Threading.Tasks.Task<string>); }
        public override string ReadToEnd() { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task<string> ReadToEndAsync() { return default(System.Threading.Tasks.Task<string>); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StreamWriter : System.IO.TextWriter
    {
        public static readonly new System.IO.StreamWriter Null;
        public StreamWriter(System.IO.Stream stream) { }
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize) { }
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize, bool leaveOpen) { }
        public StreamWriter(string path) { }
        public StreamWriter(string path, bool append) { }
        public StreamWriter(string path, bool append, System.Text.Encoding encoding) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public StreamWriter(string path, bool append, System.Text.Encoding encoding, int bufferSize) { }
        public virtual bool AutoFlush { get { return default(bool); } set { } }
        public virtual System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
        public override System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        public override void Write(char value) { }
        public override void Write(char[] buffer) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(string value) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(char value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(string value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteLineAsync() { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteLineAsync(char value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteLineAsync(string value) { return default(System.Threading.Tasks.Task); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StringReader : System.IO.TextReader
    {
        public StringReader(string s) { }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override int Peek() { return default(int); }
        public override int Read() { return default(int); }
        public override int Read(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        public override string ReadLine() { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Threading.Tasks.Task<string> ReadLineAsync() { return default(System.Threading.Tasks.Task<string>); }
        public override string ReadToEnd() { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Threading.Tasks.Task<string> ReadToEndAsync() { return default(System.Threading.Tasks.Task<string>); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StringWriter : System.IO.TextWriter
    {
        public StringWriter() { }
        public StringWriter(System.IFormatProvider formatProvider) { }
        public StringWriter(System.Text.StringBuilder sb) { }
        public StringWriter(System.Text.StringBuilder sb, System.IFormatProvider formatProvider) { }
        public override System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        public virtual System.Text.StringBuilder GetStringBuilder() { return default(System.Text.StringBuilder); }
        public override string ToString() { return default(string); }
        public override void Write(char value) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(string value) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(char value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(string value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteLineAsync(char value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteLineAsync(string value) { return default(System.Threading.Tasks.Task); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class TextReader : System.IDisposable
    {
        public static readonly System.IO.TextReader Null;
        protected TextReader() { }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual int Peek() { return default(int); }
        public virtual int Read() { return default(int); }
        public virtual int Read(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        public virtual int ReadBlock(char[] buffer, int index, int count) { buffer = default(char[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
        public virtual string ReadLine() { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task<string> ReadLineAsync() { return default(System.Threading.Tasks.Task<string>); }
        public virtual string ReadToEnd() { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task<string> ReadToEndAsync() { return default(System.Threading.Tasks.Task<string>); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class TextWriter : System.IDisposable
    {
        protected char[] CoreNewLine;
        public static readonly System.IO.TextWriter Null;
        protected TextWriter() { }
        protected TextWriter(System.IFormatProvider formatProvider) { }
        public abstract System.Text.Encoding Encoding { get; }
        public virtual System.IFormatProvider FormatProvider { get { return default(System.IFormatProvider); } }
        public virtual string NewLine { get { return default(string); } set { } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual void Flush() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
        public virtual void Write(bool value) { }
        public virtual void Write(char value) { }
        public virtual void Write(char[] buffer) { }
        public virtual void Write(char[] buffer, int index, int count) { }
        public virtual void Write(decimal value) { }
        public virtual void Write(double value) { }
        public virtual void Write(int value) { }
        public virtual void Write(long value) { }
        public virtual void Write(object value) { }
        public virtual void Write(float value) { }
        public virtual void Write(string value) { }
        public virtual void Write(string format, object arg0) { }
        public virtual void Write(string format, object arg0, object arg1) { }
        public virtual void Write(string format, object arg0, object arg1, object arg2) { }
        public virtual void Write(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ulong value) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteAsync(char value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public System.Threading.Tasks.Task WriteAsync(char[] buffer) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteAsync(string value) { return default(System.Threading.Tasks.Task); }
        public virtual void WriteLine() { }
        public virtual void WriteLine(bool value) { }
        public virtual void WriteLine(char value) { }
        public virtual void WriteLine(char[] buffer) { }
        public virtual void WriteLine(char[] buffer, int index, int count) { }
        public virtual void WriteLine(decimal value) { }
        public virtual void WriteLine(double value) { }
        public virtual void WriteLine(int value) { }
        public virtual void WriteLine(long value) { }
        public virtual void WriteLine(object value) { }
        public virtual void WriteLine(float value) { }
        public virtual void WriteLine(string value) { }
        public virtual void WriteLine(string format, object arg0) { }
        public virtual void WriteLine(string format, object arg0, object arg1) { }
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2) { }
        public virtual void WriteLine(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteLine(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteLine(ulong value) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteLineAsync() { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteLineAsync(char value) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public System.Threading.Tasks.Task WriteLineAsync(char[] buffer) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public virtual System.Threading.Tasks.Task WriteLineAsync(string value) { return default(System.Threading.Tasks.Task); }
    }
    public partial class UnmanagedMemoryAccessor : System.IDisposable
    {
        protected UnmanagedMemoryAccessor() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryAccessor(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryAccessor(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity, System.IO.FileAccess access) { }
        public bool CanRead { get { return default(bool); } }
        public bool CanWrite { get { return default(bool); } }
        public long Capacity { get { return default(long); } }
        protected bool IsOpen { get { return default(bool); } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        protected void Initialize(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity, System.IO.FileAccess access) { }
        public bool ReadBoolean(long position) { return default(bool); }
        public byte ReadByte(long position) { return default(byte); }
        [System.Security.SecuritySafeCriticalAttribute]
        public char ReadChar(long position) { return default(char); }
        [System.Security.SecuritySafeCriticalAttribute]
        public decimal ReadDecimal(long position) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public double ReadDouble(long position) { return default(double); }
        [System.Security.SecuritySafeCriticalAttribute]
        public short ReadInt16(long position) { return default(short); }
        [System.Security.SecuritySafeCriticalAttribute]
        public int ReadInt32(long position) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public long ReadInt64(long position) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public sbyte ReadSByte(long position) { return default(sbyte); }
        [System.Security.SecuritySafeCriticalAttribute]
        public float ReadSingle(long position) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public ushort ReadUInt16(long position) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public uint ReadUInt32(long position) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public ulong ReadUInt64(long position) { return default(ulong); }
        public void Write(long position, bool value) { }
        public void Write(long position, byte value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, char value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, decimal value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, double value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, short value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, int value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, long value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, sbyte value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, float value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, ushort value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, uint value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, ulong value) { }
    }
    public partial class UnmanagedMemoryStream : System.IO.Stream
    {
        [System.Security.SecuritySafeCriticalAttribute]
        protected UnmanagedMemoryStream() { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, System.IO.FileAccess access) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryStream(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryStream(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length, System.IO.FileAccess access) { }
        public override bool CanRead { get { return default(bool); } }
        public override bool CanSeek { get { return default(bool); } }
        public override bool CanWrite { get { return default(bool); } }
        public long Capacity { get { return default(long); } }
        public override long Length { get { return default(long); } }
        public override long Position { get { return default(long); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        [System.CLSCompliantAttribute(false)]
        public unsafe byte* PositionPointer { [System.Security.SecurityCriticalAttribute]get { return default(byte*); } [System.Security.SecurityCriticalAttribute]set { } }
        [System.Security.SecuritySafeCriticalAttribute]
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        protected unsafe void Initialize(byte* pointer, long length, long capacity, System.IO.FileAccess access) { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected void Initialize(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length, System.IO.FileAccess access) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int Read(byte[] buffer, int offset, int count) { buffer = default(byte[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int ReadByte() { return default(int); }
        public override long Seek(long offset, System.IO.SeekOrigin loc) { return default(long); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override void SetLength(long value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public override void Write(byte[] buffer, int offset, int count) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override void WriteByte(byte value) { }
    }
}
namespace System.Reflection
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AmbiguousMatchException : System.SystemException
    {
        public AmbiguousMatchException() { }
        public AmbiguousMatchException(string message) { }
        public AmbiguousMatchException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Assembly : System.Reflection.ICustomAttributeProvider
    {
        protected Assembly() { }
        public virtual string CodeBase { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> DefinedTypes { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo>); } }
        public virtual System.Reflection.MethodInfo EntryPoint { get { return default(System.Reflection.MethodInfo); } }
        public virtual System.Collections.Generic.IEnumerable<System.Type> ExportedTypes { get { return default(System.Collections.Generic.IEnumerable<System.Type>); } }
        public virtual string FullName { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual string ImageRuntimeVersion { get { return default(string); } }
        public virtual bool IsDynamic { get { return default(bool); } }
        public virtual string Location { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual System.Reflection.Module ManifestModule { get { return default(System.Reflection.Module); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.Module> Modules { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.Module>); } }
        public object CreateInstance(string typeName) { return default(object); }
        public object CreateInstance(string typeName, bool ignoreCase) { return default(object); }
        public static string CreateQualifiedName(string assemblyName, string typeName) { return default(string); }
        public override bool Equals(object o) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Assembly GetCallingAssembly() { return default(System.Reflection.Assembly); }
        public virtual object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Assembly GetEntryAssembly() { return default(System.Reflection.Assembly); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Assembly GetExecutingAssembly() { return default(System.Reflection.Assembly); }
        public virtual System.Type[] GetExportedTypes() { return default(System.Type[]); }
        public override int GetHashCode() { return default(int); }
        public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName) { return default(System.Reflection.ManifestResourceInfo); }
        public virtual string[] GetManifestResourceNames() { return default(string[]); }
        public virtual System.IO.Stream GetManifestResourceStream(string name) { return default(System.IO.Stream); }
        public virtual System.IO.Stream GetManifestResourceStream(System.Type type, string name) { return default(System.IO.Stream); }
        public System.Reflection.Module[] GetModules() { return default(System.Reflection.Module[]); }
        [System.Security.SecurityCriticalAttribute]
        public virtual System.Reflection.AssemblyName GetName() { return default(System.Reflection.AssemblyName); }
        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies() { return default(System.Reflection.AssemblyName[]); }
        public virtual System.Type GetType(string name) { return default(System.Type); }
        public virtual System.Type GetType(string name, bool throwOnError) { return default(System.Type); }
        public virtual System.Type GetType(string name, bool throwOnError, bool ignoreCase) { return default(System.Type); }
        public virtual System.Type[] GetTypes() { return default(System.Type[]); }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public static System.Reflection.Assembly Load(byte[] rawAssembly) { return default(System.Reflection.Assembly); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public static System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) { return default(System.Reflection.Assembly); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public static System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) { return default(System.Reflection.Assembly); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Assembly Load(string assemblyString) { return default(System.Reflection.Assembly); }
        public override string ToString() { return default(string); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyAlgorithmIdAttribute : System.Attribute
    {
        public AssemblyAlgorithmIdAttribute(System.Configuration.Assemblies.AssemblyHashAlgorithm algorithmId) { }
        [System.CLSCompliantAttribute(false)]
        public AssemblyAlgorithmIdAttribute(uint algorithmId) { }
        [System.CLSCompliantAttribute(false)]
        public uint AlgorithmId { get { return default(uint); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyCompanyAttribute : System.Attribute
    {
        public AssemblyCompanyAttribute(string company) { }
        public string Company { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyConfigurationAttribute : System.Attribute
    {
        public AssemblyConfigurationAttribute(string configuration) { }
        public string Configuration { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public enum AssemblyContentType
    {
        Default = 0,
        WindowsRuntime = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyCopyrightAttribute : System.Attribute
    {
        public AssemblyCopyrightAttribute(string copyright) { }
        public string Copyright { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyCultureAttribute : System.Attribute
    {
        public AssemblyCultureAttribute(string culture) { }
        public string Culture { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyDefaultAliasAttribute : System.Attribute
    {
        public AssemblyDefaultAliasAttribute(string defaultAlias) { }
        public string DefaultAlias { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyDelaySignAttribute : System.Attribute
    {
        public AssemblyDelaySignAttribute(bool delaySign) { }
        public bool DelaySign { get { return default(bool); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyDescriptionAttribute : System.Attribute
    {
        public AssemblyDescriptionAttribute(string description) { }
        public string Description { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyFileVersionAttribute : System.Attribute
    {
        public AssemblyFileVersionAttribute(string version) { }
        public string Version { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyFlagsAttribute : System.Attribute
    {
        public AssemblyFlagsAttribute(System.Reflection.AssemblyNameFlags assemblyFlags) { }
        public int AssemblyFlags { get { return default(int); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyInformationalVersionAttribute : System.Attribute
    {
        public AssemblyInformationalVersionAttribute(string informationalVersion) { }
        public string InformationalVersion { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyKeyFileAttribute : System.Attribute
    {
        public AssemblyKeyFileAttribute(string keyFile) { }
        public string KeyFile { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyKeyNameAttribute : System.Attribute
    {
        public AssemblyKeyNameAttribute(string keyName) { }
        public string KeyName { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true, Inherited=false)]
    public sealed partial class AssemblyMetadataAttribute : System.Attribute
    {
        public AssemblyMetadataAttribute(string key, string value) { }
        public string Key { get { return default(string); } }
        public string Value { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyName
    {
        public AssemblyName() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public AssemblyName(string assemblyName) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Reflection.AssemblyContentType ContentType { get { return default(System.Reflection.AssemblyContentType); } set { } }
        public System.Globalization.CultureInfo CultureInfo { get { return default(System.Globalization.CultureInfo); } set { } }
        public string CultureName { get { return default(string); } set { } }
        public System.Reflection.AssemblyNameFlags Flags { get { return default(System.Reflection.AssemblyNameFlags); } set { } }
        public string FullName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public System.Configuration.Assemblies.AssemblyHashAlgorithm HashAlgorithm { get { return default(System.Configuration.Assemblies.AssemblyHashAlgorithm); } set { } }
        public string Name { get { return default(string); } set { } }
        public System.Reflection.ProcessorArchitecture ProcessorArchitecture { get { return default(System.Reflection.ProcessorArchitecture); } set { } }
        public System.Version Version { get { return default(System.Version); } set { } }
        public byte[] GetPublicKey() { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public byte[] GetPublicKeyToken() { return default(byte[]); }
        public void SetPublicKey(byte[] publicKey) { }
        public void SetPublicKeyToken(byte[] publicKeyToken) { }
        public override string ToString() { return default(string); }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum AssemblyNameFlags
    {
        EnableJITcompileOptimizer = 16384,
        EnableJITcompileTracking = 32768,
        None = 0,
        PublicKey = 1,
        Retargetable = 256,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyProductAttribute : System.Attribute
    {
        public AssemblyProductAttribute(string product) { }
        public string Product { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false, AllowMultiple=false)]
    public sealed partial class AssemblySignatureKeyAttribute : System.Attribute
    {
        public AssemblySignatureKeyAttribute(string publicKey, string countersignature) { }
        public string Countersignature { get { return default(string); } }
        public string PublicKey { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyTitleAttribute : System.Attribute
    {
        public AssemblyTitleAttribute(string title) { }
        public string Title { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyTrademarkAttribute : System.Attribute
    {
        public AssemblyTrademarkAttribute(string trademark) { }
        public string Trademark { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AssemblyVersionAttribute : System.Attribute
    {
        public AssemblyVersionAttribute(string version) { }
        public string Version { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(2))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Binder
    {
        protected Binder() { }
        public abstract System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags bindingAttr, System.Reflection.FieldInfo[] match, object value, System.Globalization.CultureInfo culture);
        public abstract System.Reflection.MethodBase BindToMethod(System.Reflection.BindingFlags bindingAttr, System.Reflection.MethodBase[] match, ref object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] names, out object state);
        public abstract object ChangeType(object value, System.Type type, System.Globalization.CultureInfo culture);
        public abstract void ReorderArgumentArray(ref object[] args, object state);
        public abstract System.Reflection.MethodBase SelectMethod(System.Reflection.BindingFlags bindingAttr, System.Reflection.MethodBase[] match, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        public abstract System.Reflection.PropertyInfo SelectProperty(System.Reflection.BindingFlags bindingAttr, System.Reflection.PropertyInfo[] match, System.Type returnType, System.Type[] indexes, System.Reflection.ParameterModifier[] modifiers);
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum BindingFlags
    {
        CreateInstance = 512,
        DeclaredOnly = 2,
        Default = 0,
        ExactBinding = 65536,
        FlattenHierarchy = 64,
        GetField = 1024,
        GetProperty = 4096,
        IgnoreCase = 1,
        IgnoreReturn = 16777216,
        Instance = 4,
        InvokeMethod = 256,
        NonPublic = 32,
        OptionalParamBinding = 262144,
        Public = 16,
        PutDispProperty = 16384,
        PutRefDispProperty = 32768,
        SetField = 2048,
        SetProperty = 8192,
        Static = 8,
        SuppressChangeType = 131072,
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CallingConventions
    {
        Any = 3,
        ExplicitThis = 64,
        HasThis = 32,
        Standard = 1,
        VarArgs = 2,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class ConstructorInfo : System.Reflection.MethodBase
    {
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static readonly string ConstructorName;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static readonly string TypeConstructorName;
        protected ConstructorInfo() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public object Invoke(object[] parameters) { return default(object); }
        public abstract object Invoke(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CustomAttributeData
    {
        internal CustomAttributeData() { }
        public System.Type AttributeType { get { return default(System.Type); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Reflection.ConstructorInfo Constructor { get { return default(System.Reflection.ConstructorInfo); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeTypedArgument> ConstructorArguments { get { return default(System.Collections.Generic.IList<System.Reflection.CustomAttributeTypedArgument>); } }
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeNamedArgument> NamedArguments { get { return default(System.Collections.Generic.IList<System.Reflection.CustomAttributeNamedArgument>); } }
        public override bool Equals(object obj) { return default(bool); }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Assembly target) { return default(System.Collections.Generic.IList<System.Reflection.CustomAttributeData>); }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.MemberInfo target) { return default(System.Collections.Generic.IList<System.Reflection.CustomAttributeData>); }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Module target) { return default(System.Collections.Generic.IList<System.Reflection.CustomAttributeData>); }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.ParameterInfo target) { return default(System.Collections.Generic.IList<System.Reflection.CustomAttributeData>); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    public static partial class CustomAttributeExtensions
    {
        public static System.Attribute GetCustomAttribute(this System.Reflection.Assembly element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(this System.Reflection.MemberInfo element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(this System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(this System.Reflection.Module element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(this System.Reflection.ParameterInfo element, System.Type attributeType) { return default(System.Attribute); }
        public static System.Attribute GetCustomAttribute(this System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { return default(System.Attribute); }
        public static T GetCustomAttribute<T>(this System.Reflection.Assembly element) where T : System.Attribute { return default(T); }
        public static T GetCustomAttribute<T>(this System.Reflection.MemberInfo element) where T : System.Attribute { return default(T); }
        public static T GetCustomAttribute<T>(this System.Reflection.MemberInfo element, bool inherit) where T : System.Attribute { return default(T); }
        public static T GetCustomAttribute<T>(this System.Reflection.Module element) where T : System.Attribute { return default(T); }
        public static T GetCustomAttribute<T>(this System.Reflection.ParameterInfo element) where T : System.Attribute { return default(T); }
        public static T GetCustomAttribute<T>(this System.Reflection.ParameterInfo element, bool inherit) where T : System.Attribute { return default(T); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Assembly element) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Assembly element, System.Type attributeType) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element, bool inherit) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element, System.Type attributeType) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Module element) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Module element, System.Type attributeType) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element, bool inherit) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element, System.Type attributeType) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.Assembly element) where T : System.Attribute { return default(System.Collections.Generic.IEnumerable<T>); }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.MemberInfo element) where T : System.Attribute { return default(System.Collections.Generic.IEnumerable<T>); }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.MemberInfo element, bool inherit) where T : System.Attribute { return default(System.Collections.Generic.IEnumerable<T>); }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.Module element) where T : System.Attribute { return default(System.Collections.Generic.IEnumerable<T>); }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.ParameterInfo element) where T : System.Attribute { return default(System.Collections.Generic.IEnumerable<T>); }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.ParameterInfo element, bool inherit) where T : System.Attribute { return default(System.Collections.Generic.IEnumerable<T>); }
        public static bool IsDefined(this System.Reflection.Assembly element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(this System.Reflection.MemberInfo element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(this System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { return default(bool); }
        public static bool IsDefined(this System.Reflection.Module element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(this System.Reflection.ParameterInfo element, System.Type attributeType) { return default(bool); }
        public static bool IsDefined(this System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CustomAttributeFormatException : System.FormatException
    {
        public CustomAttributeFormatException() { }
        public CustomAttributeFormatException(string message) { }
        public CustomAttributeFormatException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CustomAttributeNamedArgument
    {
        public bool IsField { get { return default(bool); } }
        public string MemberName { get { return default(string); } }
        public System.Reflection.CustomAttributeTypedArgument TypedValue { get { return default(System.Reflection.CustomAttributeTypedArgument); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.CustomAttributeNamedArgument left, System.Reflection.CustomAttributeNamedArgument right) { return default(bool); }
        public static bool operator !=(System.Reflection.CustomAttributeNamedArgument left, System.Reflection.CustomAttributeNamedArgument right) { return default(bool); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CustomAttributeTypedArgument
    {
        public System.Type ArgumentType { get { return default(System.Type); } }
        public object Value { get { return default(object); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.CustomAttributeTypedArgument left, System.Reflection.CustomAttributeTypedArgument right) { return default(bool); }
        public static bool operator !=(System.Reflection.CustomAttributeTypedArgument left, System.Reflection.CustomAttributeTypedArgument right) { return default(bool); }
        public override string ToString() { return default(string); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1036))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DefaultMemberAttribute : System.Attribute
    {
        public DefaultMemberAttribute(string memberName) { }
        public string MemberName { get { return default(string); } }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum EventAttributes
    {
        None = 0,
        ReservedMask = 1024,
        RTSpecialName = 1024,
        SpecialName = 512,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class EventInfo : System.Reflection.MemberInfo
    {
        protected EventInfo() { }
        public virtual System.Reflection.MethodInfo AddMethod { get { return default(System.Reflection.MethodInfo); } }
        public abstract System.Reflection.EventAttributes Attributes { get; }
        public virtual System.Type EventHandlerType { get { return default(System.Type); } }
        public virtual bool IsMulticast { get { return default(bool); } }
        public bool IsSpecialName { get { return default(bool); } }
        public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
        public virtual System.Reflection.MethodInfo RaiseMethod { get { return default(System.Reflection.MethodInfo); } }
        public virtual System.Reflection.MethodInfo RemoveMethod { get { return default(System.Reflection.MethodInfo); } }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual void AddEventHandler(object target, System.Delegate handler) { }
        public override bool Equals(object obj) { return default(bool); }
        public System.Reflection.MethodInfo GetAddMethod() { return default(System.Reflection.MethodInfo); }
        public abstract System.Reflection.MethodInfo GetAddMethod(bool nonPublic);
        public override int GetHashCode() { return default(int); }
        public System.Reflection.MethodInfo GetRaiseMethod() { return default(System.Reflection.MethodInfo); }
        public abstract System.Reflection.MethodInfo GetRaiseMethod(bool nonPublic);
        public System.Reflection.MethodInfo GetRemoveMethod() { return default(System.Reflection.MethodInfo); }
        public abstract System.Reflection.MethodInfo GetRemoveMethod(bool nonPublic);
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual void RemoveEventHandler(object target, System.Delegate handler) { }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FieldAttributes
    {
        Assembly = 3,
        FamANDAssem = 2,
        Family = 4,
        FamORAssem = 5,
        FieldAccessMask = 7,
        HasDefault = 32768,
        HasFieldMarshal = 4096,
        HasFieldRVA = 256,
        InitOnly = 32,
        Literal = 64,
        NotSerialized = 128,
        PinvokeImpl = 8192,
        Private = 1,
        PrivateScope = 0,
        Public = 6,
        ReservedMask = 38144,
        RTSpecialName = 1024,
        SpecialName = 512,
        Static = 16,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class FieldInfo : System.Reflection.MemberInfo
    {
        protected FieldInfo() { }
        public abstract System.Reflection.FieldAttributes Attributes { get; }
        public abstract System.RuntimeFieldHandle FieldHandle { get; }
        public abstract System.Type FieldType { get; }
        public bool IsAssembly { get { return default(bool); } }
        public bool IsFamily { get { return default(bool); } }
        public bool IsFamilyAndAssembly { get { return default(bool); } }
        public bool IsFamilyOrAssembly { get { return default(bool); } }
        public bool IsInitOnly { get { return default(bool); } }
        public bool IsLiteral { get { return default(bool); } }
        public bool IsNotSerialized { get { return default(bool); } }
        public bool IsPinvokeImpl { get { return default(bool); } }
        public bool IsPrivate { get { return default(bool); } }
        public bool IsPublic { get { return default(bool); } }
        public bool IsSpecialName { get { return default(bool); } }
        public bool IsStatic { get { return default(bool); } }
        public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
        public override bool Equals(object obj) { return default(bool); }
        public static System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle) { return default(System.Reflection.FieldInfo); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle, System.RuntimeTypeHandle declaringType) { return default(System.Reflection.FieldInfo); }
        public override int GetHashCode() { return default(int); }
        public virtual System.Type[] GetOptionalCustomModifiers() { return default(System.Type[]); }
        public virtual object GetRawConstantValue() { return default(object); }
        public virtual System.Type[] GetRequiredCustomModifiers() { return default(System.Type[]); }
        public abstract object GetValue(object obj);
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public void SetValue(object obj, object value) { }
        public abstract void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture);
    }
    [System.FlagsAttribute]
    public enum GenericParameterAttributes
    {
        Contravariant = 2,
        Covariant = 1,
        DefaultConstructorConstraint = 16,
        None = 0,
        NotNullableValueTypeConstraint = 8,
        ReferenceTypeConstraint = 4,
        SpecialConstraintMask = 28,
        VarianceMask = 3,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ICustomAttributeProvider
    {
        object[] GetCustomAttributes(bool inherit);
        object[] GetCustomAttributes(System.Type attributeType, bool inherit);
        bool IsDefined(System.Type attributeType, bool inherit);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct InterfaceMapping
    {
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.MethodInfo[] InterfaceMethods;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Type InterfaceType;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.MethodInfo[] TargetMethods;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Type TargetType;
    }
    public static partial class IntrospectionExtensions
    {
        public static System.Reflection.TypeInfo GetTypeInfo(this System.Type type) { return default(System.Reflection.TypeInfo); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InvalidFilterCriteriaException : System.Exception
    {
        public InvalidFilterCriteriaException() { }
        public InvalidFilterCriteriaException(string message) { }
        public InvalidFilterCriteriaException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("AFBF15E5-C37C-11d2-B88E-00A0C9B471B8")]
    public partial interface IReflect
    {
        System.Type UnderlyingSystemType { get; }
        System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters);
    }
    public partial interface IReflectableType
    {
        System.Reflection.TypeInfo GetTypeInfo();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LocalVariableInfo
    {
        protected LocalVariableInfo() { }
        public virtual bool IsPinned { get { return default(bool); } }
        public virtual int LocalIndex { get { return default(int); } }
        public virtual System.Type LocalType { get { return default(System.Type); } }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ManifestResourceInfo
    {
        public ManifestResourceInfo(System.Reflection.Assembly containingAssembly, string containingFileName, System.Reflection.ResourceLocation resourceLocation) { }
        public virtual string FileName { get { return default(string); } }
        public virtual System.Reflection.Assembly ReferencedAssembly { get { return default(System.Reflection.Assembly); } }
        public virtual System.Reflection.ResourceLocation ResourceLocation { get { return default(System.Reflection.ResourceLocation); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate bool MemberFilter(System.Reflection.MemberInfo m, object filterCriteria);
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class MemberInfo : System.Reflection.ICustomAttributeProvider
    {
        protected MemberInfo() { }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>); } }
        public abstract System.Type DeclaringType { get; }
        public abstract System.Reflection.MemberTypes MemberType { get; }
        public virtual int MetadataToken { get { return default(int); } }
        public virtual System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public abstract string Name { get; }
        public abstract System.Type ReflectedType { get; }
        public override bool Equals(object obj) { return default(bool); }
        public abstract object[] GetCustomAttributes(bool inherit);
        public abstract object[] GetCustomAttributes(System.Type attributeType, bool inherit);
        public override int GetHashCode() { return default(int); }
        public abstract bool IsDefined(System.Type attributeType, bool inherit);
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum MemberTypes
    {
        All = 191,
        Constructor = 1,
        Custom = 64,
        Event = 2,
        Field = 4,
        Method = 8,
        NestedType = 128,
        Property = 16,
        TypeInfo = 32,
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum MethodAttributes
    {
        Abstract = 1024,
        Assembly = 3,
        CheckAccessOnOverride = 512,
        FamANDAssem = 2,
        Family = 4,
        FamORAssem = 5,
        Final = 32,
        HasSecurity = 16384,
        HideBySig = 128,
        MemberAccessMask = 7,
        NewSlot = 256,
        PinvokeImpl = 8192,
        Private = 1,
        PrivateScope = 0,
        Public = 6,
        RequireSecObject = 32768,
        ReservedMask = 53248,
        ReuseSlot = 0,
        RTSpecialName = 4096,
        SpecialName = 2048,
        Static = 16,
        UnmanagedExport = 8,
        Virtual = 64,
        VtableLayoutMask = 256,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class MethodBase : System.Reflection.MemberInfo
    {
        protected MethodBase() { }
        public abstract System.Reflection.MethodAttributes Attributes { get; }
        public virtual System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
        public virtual bool ContainsGenericParameters { get { return default(bool); } }
        public bool IsAbstract { get { return default(bool); } }
        public bool IsAssembly { get { return default(bool); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public bool IsConstructor { get { return default(bool); } }
        public bool IsFamily { get { return default(bool); } }
        public bool IsFamilyAndAssembly { get { return default(bool); } }
        public bool IsFamilyOrAssembly { get { return default(bool); } }
        public bool IsFinal { get { return default(bool); } }
        public virtual bool IsGenericMethod { get { return default(bool); } }
        public virtual bool IsGenericMethodDefinition { get { return default(bool); } }
        public bool IsHideBySig { get { return default(bool); } }
        public bool IsPrivate { get { return default(bool); } }
        public bool IsPublic { get { return default(bool); } }
        public bool IsSpecialName { get { return default(bool); } }
        public bool IsStatic { get { return default(bool); } }
        public bool IsVirtual { get { return default(bool); } }
        public abstract System.RuntimeMethodHandle MethodHandle { get; }
        public virtual System.Reflection.MethodImplAttributes MethodImplementationFlags { get { return default(System.Reflection.MethodImplAttributes); } }
        public override bool Equals(object obj) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Reflection.MethodBase GetCurrentMethod() { return default(System.Reflection.MethodBase); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Type[] GetGenericArguments() { return default(System.Type[]); }
        public override int GetHashCode() { return default(int); }
        public static System.Reflection.MethodBase GetMethodFromHandle(System.RuntimeMethodHandle handle) { return default(System.Reflection.MethodBase); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static System.Reflection.MethodBase GetMethodFromHandle(System.RuntimeMethodHandle handle, System.RuntimeTypeHandle declaringType) { return default(System.Reflection.MethodBase); }
        public abstract System.Reflection.MethodImplAttributes GetMethodImplementationFlags();
        public abstract System.Reflection.ParameterInfo[] GetParameters();
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public object Invoke(object obj, object[] parameters) { return default(object); }
        public abstract object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum MethodImplAttributes
    {
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        AggressiveInlining = 256,
        CodeTypeMask = 3,
        ForwardRef = 16,
        IL = 0,
        InternalCall = 4096,
        Managed = 0,
        ManagedMask = 4,
        MaxMethodImplVal = 65535,
        Native = 1,
        NoInlining = 8,
        NoOptimization = 64,
        OPTIL = 2,
        PreserveSig = 128,
        Runtime = 3,
        Synchronized = 32,
        Unmanaged = 4,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class MethodInfo : System.Reflection.MethodBase
    {
        protected MethodInfo() { }
        public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
        public virtual System.Reflection.ParameterInfo ReturnParameter { get { return default(System.Reflection.ParameterInfo); } }
        public virtual System.Type ReturnType { get { return default(System.Type); } }
        public abstract System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
        public virtual System.Delegate CreateDelegate(System.Type delegateType) { return default(System.Delegate); }
        public virtual System.Delegate CreateDelegate(System.Type delegateType, object target) { return default(System.Delegate); }
        public override bool Equals(object obj) { return default(bool); }
        public abstract System.Reflection.MethodInfo GetBaseDefinition();
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Type[] GetGenericArguments() { return default(System.Type[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition() { return default(System.Reflection.MethodInfo); }
        public override int GetHashCode() { return default(int); }
        public virtual System.Reflection.MethodInfo MakeGenericMethod(params System.Type[] typeArguments) { return default(System.Reflection.MethodInfo); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Missing
    {
        internal Missing() { }
        public static readonly System.Reflection.Missing Value;
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Module : System.Reflection.ICustomAttributeProvider
    {
        public static readonly System.Reflection.TypeFilter FilterTypeName;
        public static readonly System.Reflection.TypeFilter FilterTypeNameIgnoreCase;
        protected Module() { }
        public virtual System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>); } }
        public virtual string FullyQualifiedName { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
        public virtual int MetadataToken { get { return default(int); } }
        public virtual System.Guid ModuleVersionId { get { return default(System.Guid); } }
        public virtual string Name { get { return default(string); } }
        public virtual string ScopeName { get { return default(string); } }
        public override bool Equals(object o) { return default(bool); }
        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter filter, object filterCriteria) { return default(System.Type[]); }
        public virtual object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public System.Reflection.FieldInfo GetField(string name) { return default(System.Reflection.FieldInfo); }
        public virtual System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
        public System.Reflection.FieldInfo[] GetFields() { return default(System.Reflection.FieldInfo[]); }
        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingFlags) { return default(System.Reflection.FieldInfo[]); }
        public override int GetHashCode() { return default(int); }
        public System.Reflection.MethodInfo GetMethod(string name) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types) { return default(System.Reflection.MethodInfo); }
        protected virtual System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public System.Reflection.MethodInfo[] GetMethods() { return default(System.Reflection.MethodInfo[]); }
        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingFlags) { return default(System.Reflection.MethodInfo[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Type GetType(string className) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Type GetType(string className, bool ignoreCase) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public virtual System.Type GetType(string className, bool throwOnError, bool ignoreCase) { return default(System.Type); }
        public virtual System.Type[] GetTypes() { return default(System.Type[]); }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        public System.Reflection.FieldInfo ResolveField(int metadataToken) { return default(System.Reflection.FieldInfo); }
        public virtual System.Reflection.FieldInfo ResolveField(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { return default(System.Reflection.FieldInfo); }
        public System.Reflection.MethodBase ResolveMethod(int metadataToken) { return default(System.Reflection.MethodBase); }
        public virtual System.Reflection.MethodBase ResolveMethod(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { return default(System.Reflection.MethodBase); }
        public virtual string ResolveString(int metadataToken) { return default(string); }
        public System.Type ResolveType(int metadataToken) { return default(System.Type); }
        public virtual System.Type ResolveType(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { return default(System.Type); }
        public override string ToString() { return default(string); }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ParameterAttributes
    {
        HasDefault = 4096,
        HasFieldMarshal = 8192,
        In = 1,
        Lcid = 4,
        None = 0,
        Optional = 16,
        Out = 2,
        Reserved3 = 16384,
        Reserved4 = 32768,
        ReservedMask = 61440,
        Retval = 8,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ParameterInfo : System.Reflection.ICustomAttributeProvider
    {
        protected ParameterInfo() { }
        public virtual System.Reflection.ParameterAttributes Attributes { get { return default(System.Reflection.ParameterAttributes); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>); } }
        public virtual object DefaultValue { get { return default(object); } }
        public virtual bool HasDefaultValue { get { return default(bool); } }
        public bool IsIn { get { return default(bool); } }
        public bool IsOptional { get { return default(bool); } }
        public bool IsOut { get { return default(bool); } }
        public bool IsRetval { get { return default(bool); } }
        public virtual System.Reflection.MemberInfo Member { get { return default(System.Reflection.MemberInfo); } }
        public virtual int MetadataToken { get { return default(int); } }
        public virtual string Name { get { return default(string); } }
        public virtual System.Type ParameterType { get { return default(System.Type); } }
        public virtual int Position { get { return default(int); } }
        public virtual object RawDefaultValue { get { return default(object); } }
        public virtual object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public virtual System.Type[] GetOptionalCustomModifiers() { return default(System.Type[]); }
        public virtual System.Type[] GetRequiredCustomModifiers() { return default(System.Type[]); }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ParameterModifier
    {
        public ParameterModifier(int parameterCount) { throw new System.NotImplementedException(); }
        public bool this[int index] { get { return default(bool); } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ProcessorArchitecture
    {
        Amd64 = 4,
        Arm = 5,
        IA64 = 3,
        MSIL = 1,
        None = 0,
        X86 = 2,
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PropertyAttributes
    {
        HasDefault = 4096,
        None = 0,
        Reserved2 = 8192,
        Reserved3 = 16384,
        Reserved4 = 32768,
        ReservedMask = 62464,
        RTSpecialName = 1024,
        SpecialName = 512,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class PropertyInfo : System.Reflection.MemberInfo
    {
        protected PropertyInfo() { }
        public abstract System.Reflection.PropertyAttributes Attributes { get; }
        public abstract bool CanRead { get; }
        public abstract bool CanWrite { get; }
        public virtual System.Reflection.MethodInfo GetMethod { get { return default(System.Reflection.MethodInfo); } }
        public bool IsSpecialName { get { return default(bool); } }
        public override System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
        public abstract System.Type PropertyType { get; }
        public virtual System.Reflection.MethodInfo SetMethod { get { return default(System.Reflection.MethodInfo); } }
        public override bool Equals(object obj) { return default(bool); }
        public System.Reflection.MethodInfo[] GetAccessors() { return default(System.Reflection.MethodInfo[]); }
        public abstract System.Reflection.MethodInfo[] GetAccessors(bool nonPublic);
        public virtual object GetConstantValue() { return default(object); }
        public System.Reflection.MethodInfo GetGetMethod() { return default(System.Reflection.MethodInfo); }
        public abstract System.Reflection.MethodInfo GetGetMethod(bool nonPublic);
        public override int GetHashCode() { return default(int); }
        public abstract System.Reflection.ParameterInfo[] GetIndexParameters();
        public virtual System.Type[] GetOptionalCustomModifiers() { return default(System.Type[]); }
        public virtual object GetRawConstantValue() { return default(object); }
        public virtual System.Type[] GetRequiredCustomModifiers() { return default(System.Type[]); }
        public System.Reflection.MethodInfo GetSetMethod() { return default(System.Reflection.MethodInfo); }
        public abstract System.Reflection.MethodInfo GetSetMethod(bool nonPublic);
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public object GetValue(object obj) { return default(object); }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual object GetValue(object obj, object[] index) { return default(object); }
        public abstract object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public void SetValue(object obj, object value) { }
        [System.Diagnostics.DebuggerHiddenAttribute]
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual void SetValue(object obj, object value, object[] index) { }
        public abstract void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
    }
    public abstract partial class ReflectionContext
    {
        protected ReflectionContext() { }
        public virtual System.Reflection.TypeInfo GetTypeForObject(object value) { return default(System.Reflection.TypeInfo); }
        public abstract System.Reflection.Assembly MapAssembly(System.Reflection.Assembly assembly);
        public abstract System.Reflection.TypeInfo MapType(System.Reflection.TypeInfo type);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ReflectionTypeLoadException : System.SystemException
    {
        public ReflectionTypeLoadException(System.Type[] classes, System.Exception[] exceptions) { }
        public ReflectionTypeLoadException(System.Type[] classes, System.Exception[] exceptions, string message) { }
        public System.Exception[] LoaderExceptions { get { return default(System.Exception[]); } }
        public System.Type[] Types { get { return default(System.Type[]); } }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ResourceAttributes
    {
        Private = 2,
        Public = 1,
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ResourceLocation
    {
        ContainedInAnotherAssembly = 2,
        ContainedInManifestFile = 4,
        Embedded = 1,
    }
    public static partial class RuntimeReflectionExtensions
    {
        public static System.Reflection.MethodInfo GetMethodInfo(this System.Delegate del) { return default(System.Reflection.MethodInfo); }
        public static System.Reflection.MethodInfo GetRuntimeBaseDefinition(this System.Reflection.MethodInfo method) { return default(System.Reflection.MethodInfo); }
        public static System.Reflection.EventInfo GetRuntimeEvent(this System.Type type, string name) { return default(System.Reflection.EventInfo); }
        public static System.Collections.Generic.IEnumerable<System.Reflection.EventInfo> GetRuntimeEvents(this System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Reflection.EventInfo>); }
        public static System.Reflection.FieldInfo GetRuntimeField(this System.Type type, string name) { return default(System.Reflection.FieldInfo); }
        public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetRuntimeFields(this System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>); }
        public static System.Reflection.InterfaceMapping GetRuntimeInterfaceMap(this System.Reflection.TypeInfo typeInfo, System.Type interfaceType) { return default(System.Reflection.InterfaceMapping); }
        public static System.Reflection.MethodInfo GetRuntimeMethod(this System.Type type, string name, System.Type[] parameters) { return default(System.Reflection.MethodInfo); }
        public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetRuntimeMethods(this System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>); }
        public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetRuntimeProperties(this System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>); }
        public static System.Reflection.PropertyInfo GetRuntimeProperty(this System.Type type, string name) { return default(System.Reflection.PropertyInfo); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TargetException : System.Exception
    {
        public TargetException() { }
        public TargetException(string message) { }
        public TargetException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class TargetInvocationException : System.Exception
    {
        public TargetInvocationException(System.Exception inner) { }
        public TargetInvocationException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class TargetParameterCountException : System.Exception
    {
        public TargetParameterCountException() { }
        public TargetParameterCountException(string message) { }
        public TargetParameterCountException(string message, System.Exception inner) { }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TypeAttributes
    {
        Abstract = 128,
        AnsiClass = 0,
        AutoClass = 131072,
        AutoLayout = 0,
        BeforeFieldInit = 1048576,
        Class = 0,
        ClassSemanticsMask = 32,
        CustomFormatClass = 196608,
        CustomFormatMask = 12582912,
        ExplicitLayout = 16,
        HasSecurity = 262144,
        Import = 4096,
        Interface = 32,
        LayoutMask = 24,
        NestedAssembly = 5,
        NestedFamANDAssem = 6,
        NestedFamily = 4,
        NestedFamORAssem = 7,
        NestedPrivate = 3,
        NestedPublic = 2,
        NotPublic = 0,
        Public = 1,
        ReservedMask = 264192,
        RTSpecialName = 2048,
        Sealed = 256,
        SequentialLayout = 8,
        Serializable = 8192,
        SpecialName = 1024,
        StringFormatMask = 196608,
        UnicodeClass = 65536,
        VisibilityMask = 7,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        WindowsRuntime = 16384,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate bool TypeFilter(System.Type m, object filterCriteria);
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class TypeInfo : System.Type, System.Reflection.IReflectableType
    {
        internal TypeInfo() { }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> DeclaredConstructors { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo>); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.EventInfo> DeclaredEvents { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.EventInfo>); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> DeclaredFields { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> DeclaredMembers { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> DeclaredMethods { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> DeclaredNestedTypes { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo>); } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> DeclaredProperties { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>); } }
        public virtual System.Type[] GenericTypeParameters { get { return default(System.Type[]); } }
        public virtual System.Collections.Generic.IEnumerable<System.Type> ImplementedInterfaces { get { return default(System.Collections.Generic.IEnumerable<System.Type>); } }
        public virtual System.Type AsType() { return default(System.Type); }
        public virtual System.Reflection.EventInfo GetDeclaredEvent(string name) { return default(System.Reflection.EventInfo); }
        public virtual System.Reflection.FieldInfo GetDeclaredField(string name) { return default(System.Reflection.FieldInfo); }
        public virtual System.Reflection.MethodInfo GetDeclaredMethod(string name) { return default(System.Reflection.MethodInfo); }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetDeclaredMethods(string name) { return default(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>); }
        public virtual System.Reflection.TypeInfo GetDeclaredNestedType(string name) { return default(System.Reflection.TypeInfo); }
        public virtual System.Reflection.PropertyInfo GetDeclaredProperty(string name) { return default(System.Reflection.PropertyInfo); }
        public virtual bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { return default(bool); }
        System.Reflection.TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { return default(System.Reflection.TypeInfo); }
    }
}
namespace System.Reflection.Emit
{
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class AssemblyBuilder : System.Reflection.Assembly
    {
        internal AssemblyBuilder() { }
        public override string CodeBase { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
        public override System.Reflection.MethodInfo EntryPoint { get { return default(System.Reflection.MethodInfo); } }
        public override string FullName { get { return default(string); } }
        public override string ImageRuntimeVersion { get { return default(string); } }
        public override bool IsDynamic { get { return default(bool); } }
        public override string Location { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
        public override System.Reflection.Module ManifestModule { get { return default(System.Reflection.Module); } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) { return default(System.Reflection.Emit.AssemblyBuilder); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { return default(System.Reflection.Emit.AssemblyBuilder); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.ModuleBuilder DefineDynamicModule(string name) { return default(System.Reflection.Emit.ModuleBuilder); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo) { return default(System.Reflection.Emit.ModuleBuilder); }
        public override bool Equals(object obj) { return default(bool); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public System.Reflection.Emit.ModuleBuilder GetDynamicModule(string name) { return default(System.Reflection.Emit.ModuleBuilder); }
        public override System.Type[] GetExportedTypes() { return default(System.Type[]); }
        public override int GetHashCode() { return default(int); }
        public override System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName) { return default(System.Reflection.ManifestResourceInfo); }
        public override string[] GetManifestResourceNames() { return default(string[]); }
        public override System.IO.Stream GetManifestResourceStream(string name) { return default(System.IO.Stream); }
        public override System.IO.Stream GetManifestResourceStream(System.Type type, string name) { return default(System.IO.Stream); }
        public override System.Reflection.AssemblyName[] GetReferencedAssemblies() { return default(System.Reflection.AssemblyName[]); }
        public override System.Type GetType(string name, bool throwOnError, bool ignoreCase) { return default(System.Type); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum AssemblyBuilderAccess
    {
        Run = 1,
        RunAndCollect = 9,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class ConstructorBuilder : System.Reflection.ConstructorInfo
    {
        internal ConstructorBuilder() { }
        public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
        public override System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public bool InitLocals { get { return default(bool); } set { } }
        public override System.RuntimeMethodHandle MethodHandle { get { return default(System.RuntimeMethodHandle); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public string Signature { get { return default(string); } }
        public System.Reflection.Emit.ParameterBuilder DefineParameter(int iSequence, System.Reflection.ParameterAttributes attributes, string strParamName) { return default(System.Reflection.Emit.ParameterBuilder); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public System.Reflection.Emit.ILGenerator GetILGenerator() { return default(System.Reflection.Emit.ILGenerator); }
        public System.Reflection.Emit.ILGenerator GetILGenerator(int streamSize) { return default(System.Reflection.Emit.ILGenerator); }
        public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
        public System.Reflection.Module GetModule() { return default(System.Reflection.Module); }
        public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
        public System.Reflection.Emit.MethodToken GetToken() { return default(System.Reflection.Emit.MethodToken); }
        public override object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
        public override object Invoke(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) { }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public partial class CustomAttributeBuilder
    {
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs) { }
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.FieldInfo[] namedFields, object[] fieldValues) { }
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.PropertyInfo[] namedProperties, object[] propertyValues) { }
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.PropertyInfo[] namedProperties, object[] propertyValues, System.Reflection.FieldInfo[] namedFields, object[] fieldValues) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DynamicMethod : System.Reflection.MethodInfo
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Type owner, bool skipVisibility) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, bool restrictedSkipVisibility) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Type owner) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecurityCriticalAttribute]
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Type owner, bool skipVisibility) { }
        public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
        public override System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public bool InitLocals { get { return default(bool); } set { } }
        public override System.RuntimeMethodHandle MethodHandle { get { return default(System.RuntimeMethodHandle); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public override System.Reflection.ParameterInfo ReturnParameter { get { return default(System.Reflection.ParameterInfo); } }
        public override System.Type ReturnType { get { return default(System.Type); } }
        public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get { return default(System.Reflection.ICustomAttributeProvider); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public sealed override System.Delegate CreateDelegate(System.Type delegateType) { return default(System.Delegate); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public sealed override System.Delegate CreateDelegate(System.Type delegateType, object target) { return default(System.Delegate); }
        public System.Reflection.Emit.ParameterBuilder DefineParameter(int position, System.Reflection.ParameterAttributes attributes, string parameterName) { return default(System.Reflection.Emit.ParameterBuilder); }
        public override System.Reflection.MethodInfo GetBaseDefinition() { return default(System.Reflection.MethodInfo); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public System.Reflection.Emit.ILGenerator GetILGenerator() { return default(System.Reflection.Emit.ILGenerator); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.ILGenerator GetILGenerator(int streamSize) { return default(System.Reflection.Emit.ILGenerator); }
        public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
        public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class EnumBuilder : System.Reflection.TypeInfo
    {
        internal EnumBuilder() { }
        public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
        public override string AssemblyQualifiedName { get { return default(string); } }
        public override System.Type BaseType { get { return default(System.Type); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public override string FullName { get { return default(string); } }
        public override System.Guid GUID { get { return default(System.Guid); } }
        public override bool IsConstructedGenericType { get { return default(bool); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public override string Namespace { get { return default(string); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public override System.RuntimeTypeHandle TypeHandle { get { return default(System.RuntimeTypeHandle); } }
        public System.Reflection.Emit.TypeToken TypeToken { get { return default(System.Reflection.Emit.TypeToken); } }
        public System.Reflection.Emit.FieldBuilder UnderlyingField { get { return default(System.Reflection.Emit.FieldBuilder); } }
        public override System.Type UnderlyingSystemType { get { return default(System.Type); } }
        public System.Type CreateType() { return default(System.Type); }
        public System.Reflection.TypeInfo CreateTypeInfo() { return default(System.Reflection.TypeInfo); }
        public System.Reflection.Emit.FieldBuilder DefineLiteral(string literalName, object literalValue) { return default(System.Reflection.Emit.FieldBuilder); }
        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl() { return default(System.Reflection.TypeAttributes); }
        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.ConstructorInfo); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.ConstructorInfo[]); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public override System.Type GetElementType() { return default(System.Type); }
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Contracts", "CC1055")]
        public override System.Type GetEnumUnderlyingType() { return default(System.Type); }
        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo); }
        public override System.Reflection.EventInfo[] GetEvents() { return default(System.Reflection.EventInfo[]); }
        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo[]); }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo[]); }
        public override System.Type GetInterface(string name, bool ignoreCase) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { return default(System.Reflection.InterfaceMapping); }
        public override System.Type[] GetInterfaces() { return default(System.Type[]); }
        public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo[]); }
        public override System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Type); }
        public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { return default(System.Type[]); }
        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo[]); }
        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.PropertyInfo); }
        protected override bool HasElementTypeImpl() { return default(bool); }
        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) { return default(object); }
        protected override bool IsArrayImpl() { return default(bool); }
        public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { return default(bool); }
        protected override bool IsByRefImpl() { return default(bool); }
        protected override bool IsCOMObjectImpl() { return default(bool); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        protected override bool IsPointerImpl() { return default(bool); }
        protected override bool IsPrimitiveImpl() { return default(bool); }
        protected override bool IsValueTypeImpl() { return default(bool); }
        public override System.Type MakeArrayType() { return default(System.Type); }
        public override System.Type MakeArrayType(int rank) { return default(System.Type); }
        public override System.Type MakeByRefType() { return default(System.Type); }
        public override System.Type MakePointerType() { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class EventBuilder
    {
        internal EventBuilder() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void AddOtherMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public System.Reflection.Emit.EventToken GetEventToken() { return default(System.Reflection.Emit.EventToken); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetAddOnMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetRaiseMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetRemoveOnMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EventToken
    {
        public static readonly System.Reflection.Emit.EventToken Empty;
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.EventToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.EventToken a, System.Reflection.Emit.EventToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.EventToken a, System.Reflection.Emit.EventToken b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class FieldBuilder : System.Reflection.FieldInfo
    {
        internal FieldBuilder() { }
        public override System.Reflection.FieldAttributes Attributes { get { return default(System.Reflection.FieldAttributes); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public override System.RuntimeFieldHandle FieldHandle { get { return default(System.RuntimeFieldHandle); } }
        public override System.Type FieldType { get { return default(System.Type); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public System.Reflection.Emit.FieldToken GetToken() { return default(System.Reflection.Emit.FieldToken); }
        public override object GetValue(object obj) { return default(object); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetConstant(object defaultValue) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        [System.Security.SecurityCriticalAttribute]
        public void SetOffset(int iOffset) { }
        public override void SetValue(object obj, object val, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FieldToken
    {
        public static readonly System.Reflection.Emit.FieldToken Empty;
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.FieldToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.FieldToken a, System.Reflection.Emit.FieldToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.FieldToken a, System.Reflection.Emit.FieldToken b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FlowControl
    {
        Branch = 0,
        Break = 1,
        Call = 2,
        Cond_Branch = 3,
        Meta = 4,
        Next = 5,
        Return = 7,
        Throw = 8,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GenericTypeParameterBuilder : System.Reflection.TypeInfo
    {
        internal GenericTypeParameterBuilder() { }
        public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
        public override string AssemblyQualifiedName { get { return default(string); } }
        public override System.Type BaseType { get { return default(System.Type); } }
        public override bool ContainsGenericParameters { get { return default(bool); } }
        public override System.Reflection.MethodBase DeclaringMethod { get { return default(System.Reflection.MethodBase); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public override string FullName { get { return default(string); } }
        public override System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { return default(System.Reflection.GenericParameterAttributes); } }
        public override int GenericParameterPosition { get { return default(int); } }
        public override System.Guid GUID { get { return default(System.Guid); } }
        public override bool IsConstructedGenericType { get { return default(bool); } }
        public override bool IsGenericParameter { get { return default(bool); } }
        public override bool IsGenericType { get { return default(bool); } }
        public override bool IsGenericTypeDefinition { get { return default(bool); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public override string Namespace { get { return default(string); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public override System.RuntimeTypeHandle TypeHandle { get { return default(System.RuntimeTypeHandle); } }
        public override System.Type UnderlyingSystemType { get { return default(System.Type); } }
        public override bool Equals(object o) { return default(bool); }
        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl() { return default(System.Reflection.TypeAttributes); }
        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.ConstructorInfo); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.ConstructorInfo[]); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public override System.Type GetElementType() { return default(System.Type); }
        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo); }
        public override System.Reflection.EventInfo[] GetEvents() { return default(System.Reflection.EventInfo[]); }
        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo[]); }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo[]); }
        public override System.Type[] GetGenericArguments() { return default(System.Type[]); }
        public override System.Type GetGenericTypeDefinition() { return default(System.Type); }
        public override int GetHashCode() { return default(int); }
        public override System.Type GetInterface(string name, bool ignoreCase) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { return default(System.Reflection.InterfaceMapping); }
        public override System.Type[] GetInterfaces() { return default(System.Type[]); }
        public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo[]); }
        public override System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Type); }
        public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { return default(System.Type[]); }
        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo[]); }
        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.PropertyInfo); }
        protected override bool HasElementTypeImpl() { return default(bool); }
        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) { return default(object); }
        protected override bool IsArrayImpl() { return default(bool); }
        public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { return default(bool); }
        public override bool IsAssignableFrom(System.Type c) { return default(bool); }
        protected override bool IsByRefImpl() { return default(bool); }
        protected override bool IsCOMObjectImpl() { return default(bool); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        protected override bool IsPointerImpl() { return default(bool); }
        protected override bool IsPrimitiveImpl() { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override bool IsSubclassOf(System.Type c) { return default(bool); }
        protected override bool IsValueTypeImpl() { return default(bool); }
        public override System.Type MakeArrayType() { return default(System.Type); }
        public override System.Type MakeArrayType(int rank) { return default(System.Type); }
        public override System.Type MakeByRefType() { return default(System.Type); }
        public override System.Type MakeGenericType(params System.Type[] typeArguments) { return default(System.Type); }
        public override System.Type MakePointerType() { return default(System.Type); }
        public void SetBaseTypeConstraint(System.Type baseTypeConstraint) { }
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetGenericParameterAttributes(System.Reflection.GenericParameterAttributes genericParameterAttributes) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public void SetInterfaceConstraints(params System.Type[] interfaceConstraints) { }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ILGenerator
    {
        internal ILGenerator() { }
        public virtual int ILOffset { get { return default(int); } }
        public virtual void BeginCatchBlock(System.Type exceptionType) { }
        public virtual void BeginExceptFilterBlock() { }
        public virtual System.Reflection.Emit.Label BeginExceptionBlock() { return default(System.Reflection.Emit.Label); }
        public virtual void BeginFaultBlock() { }
        public virtual void BeginFinallyBlock() { }
        public virtual void BeginScope() { }
        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type localType) { return default(System.Reflection.Emit.LocalBuilder); }
        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type localType, bool pinned) { return default(System.Reflection.Emit.LocalBuilder); }
        public virtual System.Reflection.Emit.Label DefineLabel() { return default(System.Reflection.Emit.Label); }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, byte arg) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, double arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, short arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, int arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, long arg) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.ConstructorInfo con) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label label) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label[] labels) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.LocalBuilder local) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.SignatureHelper signature) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.FieldInfo field) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo meth) { }
        [System.CLSCompliantAttribute(false)]
        public void Emit(System.Reflection.Emit.OpCode opcode, sbyte arg) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, float arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, string str) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Type cls) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void EmitCall(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo methodInfo, System.Type[] optionalParameterTypes) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void EmitCalli(System.Reflection.Emit.OpCode opcode, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Type[] optionalParameterTypes) { }
        public virtual void EmitWriteLine(System.Reflection.Emit.LocalBuilder localBuilder) { }
        public virtual void EmitWriteLine(System.Reflection.FieldInfo fld) { }
        public virtual void EmitWriteLine(string value) { }
        public virtual void EndExceptionBlock() { }
        public virtual void EndScope() { }
        public virtual void MarkLabel(System.Reflection.Emit.Label loc) { }
        public virtual void MarkSequencePoint(System.Diagnostics.SymbolStore.ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn) { }
        public virtual void ThrowException(System.Type excType) { }
        public virtual void UsingNamespace(string usingNamespace) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Label
    {
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.Label obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.Label a, System.Reflection.Emit.Label b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.Label a, System.Reflection.Emit.Label b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class LocalBuilder : System.Reflection.LocalVariableInfo
    {
        internal LocalBuilder() { }
        public override bool IsPinned { get { return default(bool); } }
        public override int LocalIndex { get { return default(int); } }
        public override System.Type LocalType { get { return default(System.Type); } }
        public void SetLocalSymInfo(string name) { }
        public void SetLocalSymInfo(string name, int startOffset, int endOffset) { }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class MethodBuilder : System.Reflection.MethodInfo
    {
        internal MethodBuilder() { }
        public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
        public override System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
        public override bool ContainsGenericParameters { get { return default(bool); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public bool InitLocals { get { return default(bool); } set { } }
        public override bool IsGenericMethod { get { return default(bool); } }
        public override bool IsGenericMethodDefinition { get { return default(bool); } }
        public override System.RuntimeMethodHandle MethodHandle { get { return default(System.RuntimeMethodHandle); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public override System.Reflection.ParameterInfo ReturnParameter { get { return default(System.Reflection.ParameterInfo); } }
        public override System.Type ReturnType { get { return default(System.Type); } }
        public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get { return default(System.Reflection.ICustomAttributeProvider); } }
        public string Signature { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
        public System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names) { return default(System.Reflection.Emit.GenericTypeParameterBuilder[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.ParameterBuilder DefineParameter(int position, System.Reflection.ParameterAttributes attributes, string strParamName) { return default(System.Reflection.Emit.ParameterBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool Equals(object obj) { return default(bool); }
        public override System.Reflection.MethodInfo GetBaseDefinition() { return default(System.Reflection.MethodInfo); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public override System.Type[] GetGenericArguments() { return default(System.Type[]); }
        public override System.Reflection.MethodInfo GetGenericMethodDefinition() { return default(System.Reflection.MethodInfo); }
        public override int GetHashCode() { return default(int); }
        public System.Reflection.Emit.ILGenerator GetILGenerator() { return default(System.Reflection.Emit.ILGenerator); }
        public System.Reflection.Emit.ILGenerator GetILGenerator(int size) { return default(System.Reflection.Emit.ILGenerator); }
        public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { return default(System.Reflection.MethodImplAttributes); }
        public System.Reflection.Module GetModule() { return default(System.Reflection.Module); }
        public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.MethodToken GetToken() { return default(System.Reflection.Emit.MethodToken); }
        public override object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { return default(object); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        public override System.Reflection.MethodInfo MakeGenericMethod(params System.Type[] typeArguments) { return default(System.Reflection.MethodInfo); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) { }
        public void SetParameters(params System.Type[] parameterTypes) { }
        public void SetReturnType(System.Type returnType) { }
        public void SetSignature(System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct MethodToken
    {
        public static readonly System.Reflection.Emit.MethodToken Empty;
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.MethodToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.MethodToken a, System.Reflection.Emit.MethodToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.MethodToken a, System.Reflection.Emit.MethodToken b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public partial class ModuleBuilder : System.Reflection.Module
    {
        internal ModuleBuilder() { }
        public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
        public override string FullyQualifiedName { [System.Security.SecurityCriticalAttribute]get { return default(string); } }
        public override int MetadataToken { get { return default(int); } }
        public override System.Guid ModuleVersionId { get { return default(System.Guid); } }
        public override string Name { get { return default(string); } }
        public override string ScopeName { get { return default(string); } }
        public void CreateGlobalFunctions() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) { return default(System.Diagnostics.SymbolStore.ISymbolDocumentWriter); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.EnumBuilder DefineEnum(string name, System.Reflection.TypeAttributes visibility, System.Type underlyingType) { return default(System.Reflection.Emit.EnumBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { return default(System.Reflection.Emit.MethodBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.FieldBuilder DefineInitializedData(string name, byte[] data, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineType(string name) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, int typesize) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packsize) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packingSize, int typesize) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.FieldBuilder DefineUninitializedData(string name, int size, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
        public override bool Equals(object obj) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.MethodInfo GetArrayMethod(System.Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.MethodInfo); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodToken); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo con) { return default(System.Reflection.Emit.MethodToken); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingFlags) { return default(System.Reflection.FieldInfo[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo field) { return default(System.Reflection.Emit.FieldToken); }
        public override int GetHashCode() { return default(int); }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingFlags) { return default(System.Reflection.MethodInfo[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo method) { return default(System.Reflection.Emit.MethodToken); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.SignatureToken GetSignatureToken(byte[] sigBytes, int sigLength) { return default(System.Reflection.Emit.SignatureToken); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper sigHelper) { return default(System.Reflection.Emit.SignatureToken); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.StringToken GetStringConstant(string str) { return default(System.Reflection.Emit.StringToken); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Type GetType(string className) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Type GetType(string className, bool ignoreCase) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Type GetType(string className, bool throwOnError, bool ignoreCase) { return default(System.Type); }
        public override System.Type[] GetTypes() { return default(System.Type[]); }
        public System.Reflection.Emit.TypeToken GetTypeToken(string name) { return default(System.Reflection.Emit.TypeToken); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeToken GetTypeToken(System.Type type) { return default(System.Reflection.Emit.TypeToken); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        public bool IsTransient() { return default(bool); }
        public override System.Reflection.FieldInfo ResolveField(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { return default(System.Reflection.FieldInfo); }
        public override System.Reflection.MethodBase ResolveMethod(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { return default(System.Reflection.MethodBase); }
        public override string ResolveString(int metadataToken) { return default(string); }
        public override System.Type ResolveType(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct OpCode
    {
        public System.Reflection.Emit.FlowControl FlowControl { get { return default(System.Reflection.Emit.FlowControl); } }
        public string Name { get { return default(string); } }
        public System.Reflection.Emit.OpCodeType OpCodeType { get { return default(System.Reflection.Emit.OpCodeType); } }
        public System.Reflection.Emit.OperandType OperandType { get { return default(System.Reflection.Emit.OperandType); } }
        public int Size { get { return default(int); } }
        public System.Reflection.Emit.StackBehaviour StackBehaviourPop { get { return default(System.Reflection.Emit.StackBehaviour); } }
        public System.Reflection.Emit.StackBehaviour StackBehaviourPush { get { return default(System.Reflection.Emit.StackBehaviour); } }
        public short Value { get { return default(short); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.OpCode obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.OpCode a, System.Reflection.Emit.OpCode b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.OpCode a, System.Reflection.Emit.OpCode b) { return default(bool); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OpCodes
    {
        internal OpCodes() { }
        public static readonly System.Reflection.Emit.OpCode Add;
        public static readonly System.Reflection.Emit.OpCode Add_Ovf;
        public static readonly System.Reflection.Emit.OpCode Add_Ovf_Un;
        public static readonly System.Reflection.Emit.OpCode And;
        public static readonly System.Reflection.Emit.OpCode Arglist;
        public static readonly System.Reflection.Emit.OpCode Beq;
        public static readonly System.Reflection.Emit.OpCode Beq_S;
        public static readonly System.Reflection.Emit.OpCode Bge;
        public static readonly System.Reflection.Emit.OpCode Bge_S;
        public static readonly System.Reflection.Emit.OpCode Bge_Un;
        public static readonly System.Reflection.Emit.OpCode Bge_Un_S;
        public static readonly System.Reflection.Emit.OpCode Bgt;
        public static readonly System.Reflection.Emit.OpCode Bgt_S;
        public static readonly System.Reflection.Emit.OpCode Bgt_Un;
        public static readonly System.Reflection.Emit.OpCode Bgt_Un_S;
        public static readonly System.Reflection.Emit.OpCode Ble;
        public static readonly System.Reflection.Emit.OpCode Ble_S;
        public static readonly System.Reflection.Emit.OpCode Ble_Un;
        public static readonly System.Reflection.Emit.OpCode Ble_Un_S;
        public static readonly System.Reflection.Emit.OpCode Blt;
        public static readonly System.Reflection.Emit.OpCode Blt_S;
        public static readonly System.Reflection.Emit.OpCode Blt_Un;
        public static readonly System.Reflection.Emit.OpCode Blt_Un_S;
        public static readonly System.Reflection.Emit.OpCode Bne_Un;
        public static readonly System.Reflection.Emit.OpCode Bne_Un_S;
        public static readonly System.Reflection.Emit.OpCode Box;
        public static readonly System.Reflection.Emit.OpCode Br;
        public static readonly System.Reflection.Emit.OpCode Br_S;
        public static readonly System.Reflection.Emit.OpCode Break;
        public static readonly System.Reflection.Emit.OpCode Brfalse;
        public static readonly System.Reflection.Emit.OpCode Brfalse_S;
        public static readonly System.Reflection.Emit.OpCode Brtrue;
        public static readonly System.Reflection.Emit.OpCode Brtrue_S;
        public static readonly System.Reflection.Emit.OpCode Call;
        public static readonly System.Reflection.Emit.OpCode Calli;
        public static readonly System.Reflection.Emit.OpCode Callvirt;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static readonly System.Reflection.Emit.OpCode Castclass;
        public static readonly System.Reflection.Emit.OpCode Ceq;
        public static readonly System.Reflection.Emit.OpCode Cgt;
        public static readonly System.Reflection.Emit.OpCode Cgt_Un;
        public static readonly System.Reflection.Emit.OpCode Ckfinite;
        public static readonly System.Reflection.Emit.OpCode Clt;
        public static readonly System.Reflection.Emit.OpCode Clt_Un;
        public static readonly System.Reflection.Emit.OpCode Constrained;
        public static readonly System.Reflection.Emit.OpCode Conv_I;
        public static readonly System.Reflection.Emit.OpCode Conv_I1;
        public static readonly System.Reflection.Emit.OpCode Conv_I2;
        public static readonly System.Reflection.Emit.OpCode Conv_I4;
        public static readonly System.Reflection.Emit.OpCode Conv_I8;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I1;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I1_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I2;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I2_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I4;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I4_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I8;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I8_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U1;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U1_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U2;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U2_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U4;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U4_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U8;
        public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U8_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_R_Un;
        public static readonly System.Reflection.Emit.OpCode Conv_R4;
        public static readonly System.Reflection.Emit.OpCode Conv_R8;
        public static readonly System.Reflection.Emit.OpCode Conv_U;
        public static readonly System.Reflection.Emit.OpCode Conv_U1;
        public static readonly System.Reflection.Emit.OpCode Conv_U2;
        public static readonly System.Reflection.Emit.OpCode Conv_U4;
        public static readonly System.Reflection.Emit.OpCode Conv_U8;
        public static readonly System.Reflection.Emit.OpCode Cpblk;
        public static readonly System.Reflection.Emit.OpCode Cpobj;
        public static readonly System.Reflection.Emit.OpCode Div;
        public static readonly System.Reflection.Emit.OpCode Div_Un;
        public static readonly System.Reflection.Emit.OpCode Dup;
        public static readonly System.Reflection.Emit.OpCode Endfilter;
        public static readonly System.Reflection.Emit.OpCode Endfinally;
        public static readonly System.Reflection.Emit.OpCode Initblk;
        public static readonly System.Reflection.Emit.OpCode Initobj;
        public static readonly System.Reflection.Emit.OpCode Isinst;
        public static readonly System.Reflection.Emit.OpCode Jmp;
        public static readonly System.Reflection.Emit.OpCode Ldarg;
        public static readonly System.Reflection.Emit.OpCode Ldarg_0;
        public static readonly System.Reflection.Emit.OpCode Ldarg_1;
        public static readonly System.Reflection.Emit.OpCode Ldarg_2;
        public static readonly System.Reflection.Emit.OpCode Ldarg_3;
        public static readonly System.Reflection.Emit.OpCode Ldarg_S;
        public static readonly System.Reflection.Emit.OpCode Ldarga;
        public static readonly System.Reflection.Emit.OpCode Ldarga_S;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_0;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_1;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_2;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_3;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_4;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_5;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_6;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_7;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_8;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_M1;
        public static readonly System.Reflection.Emit.OpCode Ldc_I4_S;
        public static readonly System.Reflection.Emit.OpCode Ldc_I8;
        public static readonly System.Reflection.Emit.OpCode Ldc_R4;
        public static readonly System.Reflection.Emit.OpCode Ldc_R8;
        public static readonly System.Reflection.Emit.OpCode Ldelem;
        public static readonly System.Reflection.Emit.OpCode Ldelem_I;
        public static readonly System.Reflection.Emit.OpCode Ldelem_I1;
        public static readonly System.Reflection.Emit.OpCode Ldelem_I2;
        public static readonly System.Reflection.Emit.OpCode Ldelem_I4;
        public static readonly System.Reflection.Emit.OpCode Ldelem_I8;
        public static readonly System.Reflection.Emit.OpCode Ldelem_R4;
        public static readonly System.Reflection.Emit.OpCode Ldelem_R8;
        public static readonly System.Reflection.Emit.OpCode Ldelem_Ref;
        public static readonly System.Reflection.Emit.OpCode Ldelem_U1;
        public static readonly System.Reflection.Emit.OpCode Ldelem_U2;
        public static readonly System.Reflection.Emit.OpCode Ldelem_U4;
        public static readonly System.Reflection.Emit.OpCode Ldelema;
        public static readonly System.Reflection.Emit.OpCode Ldfld;
        public static readonly System.Reflection.Emit.OpCode Ldflda;
        public static readonly System.Reflection.Emit.OpCode Ldftn;
        public static readonly System.Reflection.Emit.OpCode Ldind_I;
        public static readonly System.Reflection.Emit.OpCode Ldind_I1;
        public static readonly System.Reflection.Emit.OpCode Ldind_I2;
        public static readonly System.Reflection.Emit.OpCode Ldind_I4;
        public static readonly System.Reflection.Emit.OpCode Ldind_I8;
        public static readonly System.Reflection.Emit.OpCode Ldind_R4;
        public static readonly System.Reflection.Emit.OpCode Ldind_R8;
        public static readonly System.Reflection.Emit.OpCode Ldind_Ref;
        public static readonly System.Reflection.Emit.OpCode Ldind_U1;
        public static readonly System.Reflection.Emit.OpCode Ldind_U2;
        public static readonly System.Reflection.Emit.OpCode Ldind_U4;
        public static readonly System.Reflection.Emit.OpCode Ldlen;
        public static readonly System.Reflection.Emit.OpCode Ldloc;
        public static readonly System.Reflection.Emit.OpCode Ldloc_0;
        public static readonly System.Reflection.Emit.OpCode Ldloc_1;
        public static readonly System.Reflection.Emit.OpCode Ldloc_2;
        public static readonly System.Reflection.Emit.OpCode Ldloc_3;
        public static readonly System.Reflection.Emit.OpCode Ldloc_S;
        public static readonly System.Reflection.Emit.OpCode Ldloca;
        public static readonly System.Reflection.Emit.OpCode Ldloca_S;
        public static readonly System.Reflection.Emit.OpCode Ldnull;
        public static readonly System.Reflection.Emit.OpCode Ldobj;
        public static readonly System.Reflection.Emit.OpCode Ldsfld;
        public static readonly System.Reflection.Emit.OpCode Ldsflda;
        public static readonly System.Reflection.Emit.OpCode Ldstr;
        public static readonly System.Reflection.Emit.OpCode Ldtoken;
        public static readonly System.Reflection.Emit.OpCode Ldvirtftn;
        public static readonly System.Reflection.Emit.OpCode Leave;
        public static readonly System.Reflection.Emit.OpCode Leave_S;
        public static readonly System.Reflection.Emit.OpCode Localloc;
        public static readonly System.Reflection.Emit.OpCode Mkrefany;
        public static readonly System.Reflection.Emit.OpCode Mul;
        public static readonly System.Reflection.Emit.OpCode Mul_Ovf;
        public static readonly System.Reflection.Emit.OpCode Mul_Ovf_Un;
        public static readonly System.Reflection.Emit.OpCode Neg;
        public static readonly System.Reflection.Emit.OpCode Newarr;
        public static readonly System.Reflection.Emit.OpCode Newobj;
        public static readonly System.Reflection.Emit.OpCode Nop;
        public static readonly System.Reflection.Emit.OpCode Not;
        public static readonly System.Reflection.Emit.OpCode Or;
        public static readonly System.Reflection.Emit.OpCode Pop;
        public static readonly System.Reflection.Emit.OpCode Prefix1;
        public static readonly System.Reflection.Emit.OpCode Prefix2;
        public static readonly System.Reflection.Emit.OpCode Prefix3;
        public static readonly System.Reflection.Emit.OpCode Prefix4;
        public static readonly System.Reflection.Emit.OpCode Prefix5;
        public static readonly System.Reflection.Emit.OpCode Prefix6;
        public static readonly System.Reflection.Emit.OpCode Prefix7;
        public static readonly System.Reflection.Emit.OpCode Prefixref;
        public static readonly System.Reflection.Emit.OpCode Readonly;
        public static readonly System.Reflection.Emit.OpCode Refanytype;
        public static readonly System.Reflection.Emit.OpCode Refanyval;
        public static readonly System.Reflection.Emit.OpCode Rem;
        public static readonly System.Reflection.Emit.OpCode Rem_Un;
        public static readonly System.Reflection.Emit.OpCode Ret;
        public static readonly System.Reflection.Emit.OpCode Rethrow;
        public static readonly System.Reflection.Emit.OpCode Shl;
        public static readonly System.Reflection.Emit.OpCode Shr;
        public static readonly System.Reflection.Emit.OpCode Shr_Un;
        public static readonly System.Reflection.Emit.OpCode Sizeof;
        public static readonly System.Reflection.Emit.OpCode Starg;
        public static readonly System.Reflection.Emit.OpCode Starg_S;
        public static readonly System.Reflection.Emit.OpCode Stelem;
        public static readonly System.Reflection.Emit.OpCode Stelem_I;
        public static readonly System.Reflection.Emit.OpCode Stelem_I1;
        public static readonly System.Reflection.Emit.OpCode Stelem_I2;
        public static readonly System.Reflection.Emit.OpCode Stelem_I4;
        public static readonly System.Reflection.Emit.OpCode Stelem_I8;
        public static readonly System.Reflection.Emit.OpCode Stelem_R4;
        public static readonly System.Reflection.Emit.OpCode Stelem_R8;
        public static readonly System.Reflection.Emit.OpCode Stelem_Ref;
        public static readonly System.Reflection.Emit.OpCode Stfld;
        public static readonly System.Reflection.Emit.OpCode Stind_I;
        public static readonly System.Reflection.Emit.OpCode Stind_I1;
        public static readonly System.Reflection.Emit.OpCode Stind_I2;
        public static readonly System.Reflection.Emit.OpCode Stind_I4;
        public static readonly System.Reflection.Emit.OpCode Stind_I8;
        public static readonly System.Reflection.Emit.OpCode Stind_R4;
        public static readonly System.Reflection.Emit.OpCode Stind_R8;
        public static readonly System.Reflection.Emit.OpCode Stind_Ref;
        public static readonly System.Reflection.Emit.OpCode Stloc;
        public static readonly System.Reflection.Emit.OpCode Stloc_0;
        public static readonly System.Reflection.Emit.OpCode Stloc_1;
        public static readonly System.Reflection.Emit.OpCode Stloc_2;
        public static readonly System.Reflection.Emit.OpCode Stloc_3;
        public static readonly System.Reflection.Emit.OpCode Stloc_S;
        public static readonly System.Reflection.Emit.OpCode Stobj;
        public static readonly System.Reflection.Emit.OpCode Stsfld;
        public static readonly System.Reflection.Emit.OpCode Sub;
        public static readonly System.Reflection.Emit.OpCode Sub_Ovf;
        public static readonly System.Reflection.Emit.OpCode Sub_Ovf_Un;
        public static readonly System.Reflection.Emit.OpCode Switch;
        public static readonly System.Reflection.Emit.OpCode Tailcall;
        public static readonly System.Reflection.Emit.OpCode Throw;
        public static readonly System.Reflection.Emit.OpCode Unaligned;
        public static readonly System.Reflection.Emit.OpCode Unbox;
        public static readonly System.Reflection.Emit.OpCode Unbox_Any;
        public static readonly System.Reflection.Emit.OpCode Volatile;
        public static readonly System.Reflection.Emit.OpCode Xor;
        public static bool TakesSingleByteArgument(System.Reflection.Emit.OpCode inst) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum OpCodeType
    {
        Macro = 1,
        Nternal = 2,
        Objmodel = 3,
        Prefix = 4,
        Primitive = 5,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum OperandType
    {
        InlineBrTarget = 0,
        InlineField = 1,
        InlineI = 2,
        InlineI8 = 3,
        InlineMethod = 4,
        InlineNone = 5,
        InlineR = 7,
        InlineSig = 9,
        InlineString = 10,
        InlineSwitch = 11,
        InlineTok = 12,
        InlineType = 13,
        InlineVar = 14,
        ShortInlineBrTarget = 15,
        ShortInlineI = 16,
        ShortInlineR = 17,
        ShortInlineVar = 18,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PackingSize
    {
        Size1 = 1,
        Size128 = 128,
        Size16 = 16,
        Size2 = 2,
        Size32 = 32,
        Size4 = 4,
        Size64 = 64,
        Size8 = 8,
        Unspecified = 0,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ParameterBuilder
    {
        internal ParameterBuilder() { }
        public virtual int Attributes { get { return default(int); } }
        public bool IsIn { get { return default(bool); } }
        public bool IsOptional { get { return default(bool); } }
        public bool IsOut { get { return default(bool); } }
        public virtual string Name { get { return default(string); } }
        public virtual int Position { get { return default(int); } }
        public virtual System.Reflection.Emit.ParameterToken GetToken() { return default(System.Reflection.Emit.ParameterToken); }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void SetConstant(object defaultValue) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ParameterToken
    {
        public static readonly System.Reflection.Emit.ParameterToken Empty;
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.ParameterToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.ParameterToken a, System.Reflection.Emit.ParameterToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.ParameterToken a, System.Reflection.Emit.ParameterToken b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PEFileKinds
    {
        ConsoleApplication = 2,
        Dll = 1,
        WindowApplication = 3,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class PropertyBuilder : System.Reflection.PropertyInfo
    {
        internal PropertyBuilder() { }
        public override System.Reflection.PropertyAttributes Attributes { get { return default(System.Reflection.PropertyAttributes); } }
        public override bool CanRead { get { return default(bool); } }
        public override bool CanWrite { get { return default(bool); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public System.Reflection.Emit.PropertyToken PropertyToken { get { return default(System.Reflection.Emit.PropertyToken); } }
        public override System.Type PropertyType { get { return default(System.Type); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        [System.Security.SecuritySafeCriticalAttribute]
        public void AddOtherMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public override System.Reflection.MethodInfo[] GetAccessors(bool nonPublic) { return default(System.Reflection.MethodInfo[]); }
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public override System.Reflection.MethodInfo GetGetMethod(bool nonPublic) { return default(System.Reflection.MethodInfo); }
        public override System.Reflection.ParameterInfo[] GetIndexParameters() { return default(System.Reflection.ParameterInfo[]); }
        public override System.Reflection.MethodInfo GetSetMethod(bool nonPublic) { return default(System.Reflection.MethodInfo); }
        public override object GetValue(object obj, object[] index) { return default(object); }
        public override object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) { return default(object); }
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetConstant(object defaultValue) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetGetMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetSetMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public override void SetValue(object obj, object value, object[] index) { }
        public override void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PropertyToken
    {
        public static readonly System.Reflection.Emit.PropertyToken Empty;
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.PropertyToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.PropertyToken a, System.Reflection.Emit.PropertyToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.PropertyToken a, System.Reflection.Emit.PropertyToken b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SignatureHelper
    {
        internal SignatureHelper() { }
        public void AddArgument(System.Type clsArgument) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void AddArgument(System.Type argument, bool pinned) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void AddArgument(System.Type argument, System.Type[] requiredCustomModifiers, System.Type[] optionalCustomModifiers) { }
        public void AddArguments(System.Type[] arguments, System.Type[][] requiredCustomModifiers, System.Type[][] optionalCustomModifiers) { }
        public void AddSentinel() { }
        public override bool Equals(object obj) { return default(bool); }
        public static System.Reflection.Emit.SignatureHelper GetFieldSigHelper(System.Reflection.Module mod) { return default(System.Reflection.Emit.SignatureHelper); }
        public override int GetHashCode() { return default(int); }
        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper() { return default(System.Reflection.Emit.SignatureHelper); }
        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper(System.Reflection.Module mod) { return default(System.Reflection.Emit.SignatureHelper); }
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions callingConvention, System.Type returnType) { return default(System.Reflection.Emit.SignatureHelper); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, System.Type returnType) { return default(System.Reflection.Emit.SignatureHelper); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Runtime.InteropServices.CallingConvention unmanagedCallConv, System.Type returnType) { return default(System.Reflection.Emit.SignatureHelper); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.SignatureHelper); }
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Runtime.InteropServices.CallingConvention unmanagedCallingConvention, System.Type returnType) { return default(System.Reflection.Emit.SignatureHelper); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { return default(System.Reflection.Emit.SignatureHelper); }
        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.SignatureHelper); }
        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { return default(System.Reflection.Emit.SignatureHelper); }
        public byte[] GetSignature() { return default(byte[]); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SignatureToken
    {
        public static readonly System.Reflection.Emit.SignatureToken Empty;
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.SignatureToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.SignatureToken a, System.Reflection.Emit.SignatureToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.SignatureToken a, System.Reflection.Emit.SignatureToken b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum StackBehaviour
    {
        Pop0 = 0,
        Pop1 = 1,
        Pop1_pop1 = 2,
        Popi = 3,
        Popi_pop1 = 4,
        Popi_popi = 5,
        Popi_popi_popi = 7,
        Popi_popi8 = 6,
        Popi_popr4 = 8,
        Popi_popr8 = 9,
        Popref = 10,
        Popref_pop1 = 11,
        Popref_popi = 12,
        Popref_popi_pop1 = 28,
        Popref_popi_popi = 13,
        Popref_popi_popi8 = 14,
        Popref_popi_popr4 = 15,
        Popref_popi_popr8 = 16,
        Popref_popi_popref = 17,
        Push0 = 18,
        Push1 = 19,
        Push1_push1 = 20,
        Pushi = 21,
        Pushi8 = 22,
        Pushr4 = 23,
        Pushr8 = 24,
        Pushref = 25,
        Varpop = 26,
        Varpush = 27,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct StringToken
    {
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.StringToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.StringToken a, System.Reflection.Emit.StringToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.StringToken a, System.Reflection.Emit.StringToken b) { return default(bool); }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class TypeBuilder : System.Reflection.TypeInfo
    {
        internal TypeBuilder() { }
        public const int UnspecifiedTypeSize = 0;
        public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
        public override string AssemblyQualifiedName { get { return default(string); } }
        public override System.Type BaseType { get { return default(System.Type); } }
        public override System.Reflection.MethodBase DeclaringMethod { get { return default(System.Reflection.MethodBase); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public override string FullName { get { return default(string); } }
        public override System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { return default(System.Reflection.GenericParameterAttributes); } }
        public override int GenericParameterPosition { get { return default(int); } }
        public override System.Guid GUID { get { return default(System.Guid); } }
        public override bool IsConstructedGenericType { get { return default(bool); } }
        public override bool IsGenericParameter { get { return default(bool); } }
        public override bool IsGenericType { get { return default(bool); } }
        public override bool IsGenericTypeDefinition { get { return default(bool); } }
        public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
        public override string Name { get { return default(string); } }
        public override string Namespace { get { return default(string); } }
        public System.Reflection.Emit.PackingSize PackingSize { get { return default(System.Reflection.Emit.PackingSize); } }
        public override System.Type ReflectedType { get { return default(System.Type); } }
        public int Size { get { return default(int); } }
        public override System.RuntimeTypeHandle TypeHandle { get { return default(System.RuntimeTypeHandle); } }
        public System.Reflection.Emit.TypeToken TypeToken { get { return default(System.Reflection.Emit.TypeToken); } }
        public override System.Type UnderlyingSystemType { get { return default(System.Type); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void AddInterfaceImplementation(System.Type interfaceType) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Type CreateType() { return default(System.Type); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.TypeInfo CreateTypeInfo() { return default(System.Reflection.TypeInfo); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type[] parameterTypes) { return default(System.Reflection.Emit.ConstructorBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type[] parameterTypes, System.Type[][] requiredCustomModifiers, System.Type[][] optionalCustomModifiers) { return default(System.Reflection.Emit.ConstructorBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Reflection.Emit.ConstructorBuilder DefineDefaultConstructor(System.Reflection.MethodAttributes attributes) { return default(System.Reflection.Emit.ConstructorBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.EventBuilder DefineEvent(string name, System.Reflection.EventAttributes attributes, System.Type eventtype) { return default(System.Reflection.Emit.EventBuilder); }
        public System.Reflection.Emit.FieldBuilder DefineField(string fieldName, System.Type type, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.FieldBuilder DefineField(string fieldName, System.Type type, System.Type[] requiredCustomModifiers, System.Type[] optionalCustomModifiers, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
        public System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names) { return default(System.Reflection.Emit.GenericTypeParameterBuilder[]); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.FieldBuilder DefineInitializedData(string name, byte[] data, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes) { return default(System.Reflection.Emit.MethodBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention) { return default(System.Reflection.Emit.MethodBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { return default(System.Reflection.Emit.MethodBuilder); }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void DefineMethodOverride(System.Reflection.MethodInfo methodInfoBody, System.Reflection.MethodInfo methodInfoDeclaration) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, int typeSize) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packSize) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packSize, int typeSize) { return default(System.Reflection.Emit.TypeBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces) { return default(System.Reflection.Emit.TypeBuilder); }
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.PropertyBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { return default(System.Reflection.Emit.PropertyBuilder); }
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.PropertyBuilder); }
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { return default(System.Reflection.Emit.PropertyBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Reflection.Emit.ConstructorBuilder DefineTypeInitializer() { return default(System.Reflection.Emit.ConstructorBuilder); }
        [System.Security.SecurityCriticalAttribute]
        public System.Reflection.Emit.FieldBuilder DefineUninitializedData(string name, int size, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl() { return default(System.Reflection.TypeAttributes); }
        public static System.Reflection.ConstructorInfo GetConstructor(System.Type type, System.Reflection.ConstructorInfo constructor) { return default(System.Reflection.ConstructorInfo); }
        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.ConstructorInfo); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.ConstructorInfo[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override object[] GetCustomAttributes(bool inherit) { return default(object[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(object[]); }
        public override System.Type GetElementType() { return default(System.Type); }
        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo); }
        public override System.Reflection.EventInfo[] GetEvents() { return default(System.Reflection.EventInfo[]); }
        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo[]); }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
        public static System.Reflection.FieldInfo GetField(System.Type type, System.Reflection.FieldInfo field) { return default(System.Reflection.FieldInfo); }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo[]); }
        public override System.Type[] GetGenericArguments() { return default(System.Type[]); }
        public override System.Type GetGenericTypeDefinition() { return default(System.Type); }
        public override System.Type GetInterface(string name, bool ignoreCase) { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { return default(System.Reflection.InterfaceMapping); }
        public override System.Type[] GetInterfaces() { return default(System.Type[]); }
        public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
        public static System.Reflection.MethodInfo GetMethod(System.Type type, System.Reflection.MethodInfo method) { return default(System.Reflection.MethodInfo); }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.MethodInfo); }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo[]); }
        public override System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Type); }
        public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { return default(System.Type[]); }
        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo[]); }
        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { return default(System.Reflection.PropertyInfo); }
        protected override bool HasElementTypeImpl() { return default(bool); }
        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) { return default(object); }
        protected override bool IsArrayImpl() { return default(bool); }
        public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { return default(bool); }
        public override bool IsAssignableFrom(System.Type c) { return default(bool); }
        protected override bool IsByRefImpl() { return default(bool); }
        protected override bool IsCOMObjectImpl() { return default(bool); }
        public bool IsCreated() { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
        protected override bool IsPointerImpl() { return default(bool); }
        protected override bool IsPrimitiveImpl() { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override bool IsSubclassOf(System.Type c) { return default(bool); }
        public override System.Type MakeArrayType() { return default(System.Type); }
        public override System.Type MakeArrayType(int rank) { return default(System.Type); }
        public override System.Type MakeByRefType() { return default(System.Type); }
        public override System.Type MakeGenericType(params System.Type[] typeArguments) { return default(System.Type); }
        public override System.Type MakePointerType() { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetParent(System.Type parent) { }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TypeToken
    {
        public static readonly System.Reflection.Emit.TypeToken Empty;
        public int Token { get { return default(int); } }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Reflection.Emit.TypeToken obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Reflection.Emit.TypeToken a, System.Reflection.Emit.TypeToken b) { return default(bool); }
        public static bool operator !=(System.Reflection.Emit.TypeToken a, System.Reflection.Emit.TypeToken b) { return default(bool); }
    }
}
namespace System.Reflection.Metadata
{
    public static partial class AssemblyExtensions
    {
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe static bool TryGetRawMetadata(this System.Reflection.Assembly assembly, out byte* blob, out int length) { blob = default(byte*); length = default(int); return default(bool); }
    }
}
namespace System.Resources
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IResourceReader : System.Collections.IEnumerable, System.IDisposable
    {
        new System.Collections.IDictionaryEnumerator GetEnumerator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MissingManifestResourceException : System.SystemException
    {
        public MissingManifestResourceException() { }
        public MissingManifestResourceException(string message) { }
        public MissingManifestResourceException(string message, System.Exception inner) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class NeutralResourcesLanguageAttribute : System.Attribute
    {
        public NeutralResourcesLanguageAttribute(string cultureName) { }
        public NeutralResourcesLanguageAttribute(string cultureName, System.Resources.UltimateResourceFallbackLocation location) { }
        public string CultureName { get { return default(string); } }
        public System.Resources.UltimateResourceFallbackLocation Location { get { return default(System.Resources.UltimateResourceFallbackLocation); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResourceManager
    {
        protected string BaseNameField;
        public static readonly int HeaderVersionNumber;
        public static readonly int MagicNumber;
        protected System.Reflection.Assembly MainAssembly;
        protected ResourceManager() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public ResourceManager(string baseName, System.Reflection.Assembly assembly) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public ResourceManager(string baseName, System.Reflection.Assembly assembly, System.Type usingResourceSet) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public ResourceManager(System.Type resourceSource) { }
        public virtual string BaseName { get { return default(string); } }
        public virtual bool IgnoreCase { get { return default(bool); } set { } }
        public virtual System.Type ResourceSetType { get { return default(System.Type); } }
        [System.Security.SecuritySafeCriticalAttribute]
        protected static System.Globalization.CultureInfo GetNeutralResourcesLanguage(System.Reflection.Assembly a) { return default(System.Globalization.CultureInfo); }
        public virtual object GetObject(string name) { return default(object); }
        public virtual object GetObject(string name, System.Globalization.CultureInfo culture) { return default(object); }
        protected virtual string GetResourceFileName(System.Globalization.CultureInfo culture) { return default(string); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public virtual System.Resources.ResourceSet GetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents) { return default(System.Resources.ResourceSet); }
        protected static System.Version GetSatelliteContractVersion(System.Reflection.Assembly a) { return default(System.Version); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.IO.UnmanagedMemoryStream GetStream(string name) { return default(System.IO.UnmanagedMemoryStream); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.IO.UnmanagedMemoryStream GetStream(string name, System.Globalization.CultureInfo culture) { return default(System.IO.UnmanagedMemoryStream); }
        public virtual string GetString(string name) { return default(string); }
        public virtual string GetString(string name, System.Globalization.CultureInfo culture) { return default(string); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        protected virtual System.Resources.ResourceSet InternalGetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents) { return default(System.Resources.ResourceSet); }
        public virtual void ReleaseAllResources() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResourceSet : System.Collections.IEnumerable, System.IDisposable
    {
        protected System.Resources.IResourceReader Reader;
        protected ResourceSet() { }
        [System.Security.SecurityCriticalAttribute]
        public ResourceSet(System.IO.Stream stream) { }
        [System.Security.SecurityCriticalAttribute]
        public ResourceSet(string fileName) { }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual System.Type GetDefaultReader() { return default(System.Type); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
        public virtual object GetObject(string name) { return default(object); }
        public virtual object GetObject(string name, bool ignoreCase) { return default(object); }
        public virtual string GetString(string name) { return default(string); }
        public virtual string GetString(string name, bool ignoreCase) { return default(string); }
        protected virtual void ReadResources() { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SatelliteContractVersionAttribute : System.Attribute
    {
        public SatelliteContractVersionAttribute(string version) { }
        public string Version { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum UltimateResourceFallbackLocation
    {
        MainAssembly = 0,
        Satellite = 1,
    }
}
namespace System.Runtime
{
    public enum GCLargeObjectHeapCompactionMode
    {
        CompactOnce = 2,
        Default = 1,
    }
    public enum GCLatencyMode
    {
        Batch = 0,
        Interactive = 1,
        LowLatency = 2,
        NoGCRegion = 4,
        SustainedLowLatency = 3,
    }
    public static partial class GCSettings
    {
        public static bool IsServerGC { [System.Security.SecuritySafeCriticalAttribute]get { return default(bool); } }
        public static System.Runtime.GCLargeObjectHeapCompactionMode LargeObjectHeapCompactionMode { get { return default(System.Runtime.GCLargeObjectHeapCompactionMode); } set { } }
        public static System.Runtime.GCLatencyMode LatencyMode { get { return default(System.Runtime.GCLatencyMode); } set { } }
    }
}
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AccessedThroughPropertyAttribute : System.Attribute
    {
        public AccessedThroughPropertyAttribute(string propertyName) { }
        public string PropertyName { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false, AllowMultiple=false)]
    public sealed partial class AsyncStateMachineAttribute : System.Runtime.CompilerServices.StateMachineAttribute
    {
        public AsyncStateMachineAttribute(System.Type stateMachineType) : base (default(System.Type)) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AsyncTaskMethodBuilder
    {
        public System.Threading.Tasks.Task Task { get { return default(System.Threading.Tasks.Task); } }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncTaskMethodBuilder Create() { return default(System.Runtime.CompilerServices.AsyncTaskMethodBuilder); }
        public void SetException(System.Exception exception) { }
        public void SetResult() { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AsyncTaskMethodBuilder<TResult>
    {
        public System.Threading.Tasks.Task<TResult> Task { get { return default(System.Threading.Tasks.Task<TResult>); } }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> Create() { return default(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>); }
        public void SetException(System.Exception exception) { }
        public void SetResult(TResult result) { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AsyncVoidMethodBuilder
    {
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncVoidMethodBuilder Create() { return default(System.Runtime.CompilerServices.AsyncVoidMethodBuilder); }
        public void SetException(System.Exception exception) { }
        public void SetResult() { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CallConvCdecl
    {
        internal CallConvCdecl() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CallConvFastcall
    {
        internal CallConvFastcall() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CallConvStdcall
    {
        internal CallConvStdcall() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CallConvThiscall
    {
        internal CallConvThiscall() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false)]
    public sealed partial class CallerFilePathAttribute : System.Attribute
    {
        public CallerFilePathAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false)]
    public sealed partial class CallerLineNumberAttribute : System.Attribute
    {
        public CallerLineNumberAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false)]
    public sealed partial class CallerMemberNameAttribute : System.Attribute
    {
        public CallerMemberNameAttribute() { }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CompilationRelaxations
    {
        NoStringInterning = 8,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(71))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CompilationRelaxationsAttribute : System.Attribute
    {
        public CompilationRelaxationsAttribute(int relaxations) { }
        public CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations relaxations) { }
        public int CompilationRelaxations { get { return default(int); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited=true)]
    public sealed partial class CompilerGeneratedAttribute : System.Attribute
    {
        public CompilerGeneratedAttribute() { }
    }
    public static partial class CompilerMarshalOverride
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ConditionalWeakTable<TKey, TValue> where TKey : class where TValue : class
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public ConditionalWeakTable() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Add(TKey key, TValue value) { }
        ~ConditionalWeakTable() { }
        public TValue GetOrCreateValue(TKey key) { return default(TValue); }
        [System.Security.SecuritySafeCriticalAttribute]
        public TValue GetValue(TKey key, System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback) { return default(TValue); }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Remove(TKey key) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
        public delegate TValue CreateValueCallback(TKey key);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ConfiguredTaskAwaitable
    {
        public System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { return default(System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter); }
        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct ConfiguredTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            public bool IsCompleted { get { return default(bool); } }
            public void GetResult() { }
            [System.Security.SecuritySafeCriticalAttribute]
            public void OnCompleted(System.Action continuation) { }
            [System.Security.SecurityCriticalAttribute]
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ConfiguredTaskAwaitable<TResult>
    {
        public System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter() { return default(System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter); }
        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct ConfiguredTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            public bool IsCompleted { get { return default(bool); } }
            public TResult GetResult() { return default(TResult); }
            [System.Security.SecuritySafeCriticalAttribute]
            public void OnCompleted(System.Action continuation) { }
            [System.Security.SecurityCriticalAttribute]
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    public static partial class ContractHelper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        
        public static string RaiseContractFailedEvent(System.Diagnostics.Contracts.ContractFailureKind failureKind, string userMessage, string conditionText, System.Exception innerException) { return default(string); }
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        
        public static void TriggerFailure(System.Diagnostics.Contracts.ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2304), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CustomConstantAttribute : System.Attribute
    {
        protected CustomConstantAttribute() { }
        public abstract object Value { get; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2304), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DateTimeConstantAttribute : System.Runtime.CompilerServices.CustomConstantAttribute
    {
        public DateTimeConstantAttribute(long ticks) { }
        public override object Value { get { return default(object); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2304), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DecimalConstantAttribute : System.Attribute
    {
        public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low) { }
        [System.CLSCompliantAttribute(false)]
        public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }
        public decimal Value { get { return default(decimal); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false, Inherited=false)]
    public sealed partial class DisablePrivateReflectionAttribute : System.Attribute
    {
        public DisablePrivateReflectionAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(69))]
    public sealed partial class ExtensionAttribute : System.Attribute
    {
        public ExtensionAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
    public sealed partial class FixedAddressValueTypeAttribute : System.Attribute
    {
        public FixedAddressValueTypeAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false)]
    public sealed partial class FixedBufferAttribute : System.Attribute
    {
        public FixedBufferAttribute(System.Type elementType, int length) { }
        public System.Type ElementType { get { return default(System.Type); } }
        public int Length { get { return default(int); } }
    }
    public static partial class FormattableStringFactory
    {
        public static System.FormattableString Create(string format, params object[] arguments) { return default(System.FormattableString); }
    }
    public partial interface IAsyncStateMachine
    {
        void MoveNext();
        void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
    public partial interface ICastable
    {
        System.RuntimeTypeHandle GetImplType(System.RuntimeTypeHandle interfaceType);
        bool IsInstanceOfInterface(System.RuntimeTypeHandle interfaceType, out System.Exception castError);
    }
    public partial interface ICriticalNotifyCompletion : System.Runtime.CompilerServices.INotifyCompletion
    {
        [System.Security.SecurityCriticalAttribute]
        void UnsafeOnCompleted(System.Action continuation);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128), Inherited=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IndexerNameAttribute : System.Attribute
    {
        public IndexerNameAttribute(string indexerName) { }
    }
    public partial interface INotifyCompletion
    {
        void OnCompleted(System.Action continuation);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true, Inherited=false)]
    public sealed partial class InternalsVisibleToAttribute : System.Attribute
    {
        public InternalsVisibleToAttribute(string assemblyName) { }
        public bool AllInternalsVisible { get { return default(bool); } set { } }
        public string AssemblyName { get { return default(string); } }
    }
    public static partial class IsBoxed
    {
    }
    public static partial class IsByValue
    {
    }
    public static partial class IsConst
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class IsCopyConstructed
    {
    }
    public static partial class IsExplicitlyDereferenced
    {
    }
    public static partial class IsImplicitlyDereferenced
    {
    }
    public static partial class IsJitIntrinsic
    {
    }
    public static partial class IsLong
    {
    }
    public static partial class IsSignUnspecifiedByte
    {
    }
    public static partial class IsUdtReturn
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class IsVolatile
    {
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false, AllowMultiple=false)]
    public sealed partial class IteratorStateMachineAttribute : System.Runtime.CompilerServices.StateMachineAttribute
    {
        public IteratorStateMachineAttribute(System.Type stateMachineType) : base (default(System.Type)) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum MethodCodeType
    {
        IL = 0,
        Native = 1,
        OPTIL = 2,
        Runtime = 3,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(96), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class MethodImplAttribute : System.Attribute
    {
        public System.Runtime.CompilerServices.MethodCodeType MethodCodeType;
        public MethodImplAttribute() { }
        public MethodImplAttribute(short value) { }
        public MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions methodImplOptions) { }
        public System.Runtime.CompilerServices.MethodImplOptions Value { get { return default(System.Runtime.CompilerServices.MethodImplOptions); } }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum MethodImplOptions
    {
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        AggressiveInlining = 256,
        ForwardRef = 16,
        InternalCall = 4096,
        NoInlining = 8,
        NoOptimization = 64,
        PreserveSig = 128,
        Synchronized = 32,
        Unmanaged = 4,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(8), Inherited=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class NativeCppClassAttribute : System.Attribute
    {
        public NativeCppClassAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
    public sealed partial class ReferenceAssemblyAttribute : System.Attribute
    {
        public ReferenceAssemblyAttribute() { }
        public ReferenceAssemblyAttribute(string description) { }
        public string Description { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1052), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class RequiredAttributeAttribute : System.Attribute
    {
        public RequiredAttributeAttribute(System.Type requiredContract) { }
        public System.Type RequiredContract { get { return default(System.Type); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false, AllowMultiple=false)]
    public sealed partial class RuntimeCompatibilityAttribute : System.Attribute
    {
        public RuntimeCompatibilityAttribute() { }
        public bool WrapNonExceptionThrows { get { return default(bool); } set { } }
    }
    public static partial class RuntimeHelpers
    {
        public static int OffsetToStringData { get { return default(int); } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static void EnsureSufficientExecutionStack() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static int GetHashCode(object o) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static object GetObjectValue(object obj) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static void InitializeArray(System.Array array, System.RuntimeFieldHandle fldHandle) { }
        public static void RunClassConstructor(System.RuntimeTypeHandle type) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(972))]
    public sealed partial class SpecialNameAttribute : System.Attribute
    {
        public SpecialNameAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false, AllowMultiple=false)]
    public partial class StateMachineAttribute : System.Attribute
    {
        public StateMachineAttribute(System.Type stateMachineType) { }
        public System.Type StateMachineType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    }
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        public bool IsCompleted { get { return default(bool); } }
        public void GetResult() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void OnCompleted(System.Action continuation) { }
        [System.Security.SecurityCriticalAttribute]
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TaskAwaiter<TResult> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        public bool IsCompleted { get { return default(bool); } }
        public TResult GetResult() { return default(TResult); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void OnCompleted(System.Action continuation) { }
        [System.Security.SecurityCriticalAttribute]
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5148), Inherited=false, AllowMultiple=false)]
    public sealed partial class TypeForwardedFromAttribute : System.Attribute
    {
        public TypeForwardedFromAttribute(string assemblyFullName) { }
        public string AssemblyFullName { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true, Inherited=false)]
    public sealed partial class TypeForwardedToAttribute : System.Attribute
    {
        public TypeForwardedToAttribute(System.Type destination) { }
        public System.Type Destination { get { return default(System.Type); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(8))]
    public sealed partial class UnsafeValueTypeAttribute : System.Attribute
    {
        public UnsafeValueTypeAttribute() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    public partial struct YieldAwaitable
    {
        public System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter GetAwaiter() { return default(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter); }
        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
        public partial struct YieldAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            public bool IsCompleted { get { return default(bool); } }
            public void GetResult() { }
            [System.Security.SecuritySafeCriticalAttribute]
            public void OnCompleted(System.Action continuation) { }
            [System.Security.SecurityCriticalAttribute]
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
}
namespace System.Runtime.ConstrainedExecution
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CriticalFinalizerObject
    {
        
        [System.Security.SecuritySafeCriticalAttribute]
        protected CriticalFinalizerObject() { }
        ~CriticalFinalizerObject() { }
    }
}
namespace System.Runtime.ExceptionServices
{
    public sealed partial class ExceptionDispatchInfo
    {
        internal ExceptionDispatchInfo() { }
        public System.Exception SourceException { get { return default(System.Exception); } }
        public static System.Runtime.ExceptionServices.ExceptionDispatchInfo Capture(System.Exception source) { return default(System.Runtime.ExceptionServices.ExceptionDispatchInfo); }
        public void Throw() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
    public sealed partial class HandleProcessCorruptedStateExceptionsAttribute : System.Attribute
    {
        public HandleProcessCorruptedStateExceptionsAttribute() { }
    }
}
namespace System.Runtime.InteropServices
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
    public sealed partial class AllowReversePInvokeCallsAttribute : System.Attribute
    {
        public AllowReversePInvokeCallsAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ArrayWithOffset
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public ArrayWithOffset(object array, int offset) { throw new System.NotImplementedException(); }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Runtime.InteropServices.ArrayWithOffset obj) { return default(bool); }
        public object GetArray() { return default(object); }
        public override int GetHashCode() { return default(int); }
        public int GetOffset() { return default(int); }
        public static bool operator ==(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { return default(bool); }
        public static bool operator !=(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { return default(bool); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1037), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class BestFitMappingAttribute : System.Attribute
    {
        public bool ThrowOnUnmappableChar;
        public BestFitMappingAttribute(bool BestFitMapping) { }
        public bool BestFitMapping { get { return default(bool); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class BStrWrapper
    {
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public BStrWrapper(object value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public BStrWrapper(string value) { }
        public string WrappedObject { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CallingConvention
    {
        Cdecl = 2,
        FastCall = 5,
        StdCall = 3,
        ThisCall = 4,
        Winapi = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CharSet
    {
        Ansi = 2,
        Auto = 4,
        None = 1,
        Unicode = 3,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ClassInterfaceAttribute : System.Attribute
    {
        public ClassInterfaceAttribute(short classInterfaceType) { }
        public ClassInterfaceAttribute(System.Runtime.InteropServices.ClassInterfaceType classInterfaceType) { }
        public System.Runtime.InteropServices.ClassInterfaceType Value { get { return default(System.Runtime.InteropServices.ClassInterfaceType); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ClassInterfaceType
    {
        AutoDispatch = 1,
        AutoDual = 2,
        None = 0,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1024), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class CoClassAttribute : System.Attribute
    {
        public CoClassAttribute(System.Type coClass) { }
        public System.Type CoClass { get { return default(System.Type); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComDefaultInterfaceAttribute : System.Attribute
    {
        public ComDefaultInterfaceAttribute(System.Type defaultInterface) { }
        public System.Type Value { get { return default(System.Type); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1024), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComEventInterfaceAttribute : System.Attribute
    {
        public ComEventInterfaceAttribute(System.Type SourceInterface, System.Type EventProvider) { }
        public System.Type EventProvider { get { return default(System.Type); } }
        public System.Type SourceInterface { get { return default(System.Type); } }
    }
    public static partial class ComEventsHelper
    {
        [System.Security.SecurityCriticalAttribute]
        public static void Combine(object rcw, System.Guid iid, int dispid, System.Delegate d) { }
        [System.Security.SecurityCriticalAttribute]
        public static System.Delegate Remove(object rcw, System.Guid iid, int dispid, System.Delegate d) { return default(System.Delegate); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class COMException : System.Runtime.InteropServices.ExternalException
    {
        public COMException() { }
        public COMException(string message) { }
        public COMException(string message, System.Exception inner) { }
        public COMException(string message, int errorCode) { }
        public override string ToString() { return default(string); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComImportAttribute : System.Attribute
    {
        public ComImportAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ComInterfaceType
    {
        InterfaceIsDual = 0,
        InterfaceIsIDispatch = 2,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        InterfaceIsIInspectable = 3,
        InterfaceIsIUnknown = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ComMemberType
    {
        Method = 0,
        PropGet = 1,
        PropSet = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComSourceInterfacesAttribute : System.Attribute
    {
        public ComSourceInterfacesAttribute(string sourceInterfaces) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3, System.Type sourceInterface4) { }
        public string Value { get { return default(string); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5597), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComVisibleAttribute : System.Attribute
    {
        public ComVisibleAttribute(bool visibility) { }
        public bool Value { get { return default(bool); } }
    }
    [System.Security.SecurityCriticalAttribute]
    public abstract partial class CriticalHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
    {
        protected System.IntPtr handle;
        
        protected CriticalHandle(System.IntPtr invalidHandleValue) { }
        public bool IsClosed { get { return default(bool); } }
        public abstract bool IsInvalid { get; }
        
        [System.Security.SecurityCriticalAttribute]
        public void Close() { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public void Dispose() { }
        
        [System.Security.SecurityCriticalAttribute]
        protected virtual void Dispose(bool disposing) { }
        ~CriticalHandle() { }
        
        protected abstract bool ReleaseHandle();
        
        protected void SetHandle(System.IntPtr handle) { }
        
        public void SetHandleAsInvalid() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class CurrencyWrapper
    {
        public CurrencyWrapper(decimal obj) { }
        public CurrencyWrapper(object obj) { }
        public decimal WrappedObject { get { return default(decimal); } }
    }
    public enum CustomQueryInterfaceMode
    {
        Allow = 1,
        Ignore = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public enum CustomQueryInterfaceResult
    {
        Failed = 2,
        Handled = 0,
        NotHandled = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DefaultCharSetAttribute : System.Attribute
    {
        public DefaultCharSetAttribute(System.Runtime.InteropServices.CharSet charSet) { }
        public System.Runtime.InteropServices.CharSet CharSet { get { return default(System.Runtime.InteropServices.CharSet); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(65), AllowMultiple=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class DefaultDllImportSearchPathsAttribute : System.Attribute
    {
        public DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath paths) { }
        public System.Runtime.InteropServices.DllImportSearchPath Paths { get { return default(System.Runtime.InteropServices.DllImportSearchPath); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DispatchWrapper
    {
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public DispatchWrapper(object obj) { }
        public object WrappedObject { get { return default(object); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(960), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DispIdAttribute : System.Attribute
    {
        public DispIdAttribute(int dispId) { }
        public int Value { get { return default(int); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DllImportAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CallingConvention CallingConvention;
        public System.Runtime.InteropServices.CharSet CharSet;
        public string EntryPoint;
        public bool ExactSpelling;
        public bool PreserveSig;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public DllImportAttribute(string dllName) { }
        public string Value { get { return default(string); } }
    }
    [System.FlagsAttribute]
    public enum DllImportSearchPath
    {
        ApplicationDirectory = 512,
        AssemblyDirectory = 2,
        LegacyBehavior = 0,
        SafeDirectories = 4096,
        System32 = 2048,
        UseDllDirectoryForDependencies = 256,
        UserDirectories = 1024,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ErrorWrapper
    {
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public ErrorWrapper(System.Exception e) { }
        public ErrorWrapper(int errorCode) { }
        public ErrorWrapper(object errorCode) { }
        public int ErrorCode { get { return default(int); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ExternalException : System.SystemException
    {
        public ExternalException() { }
        public ExternalException(string message) { }
        public ExternalException(string message, System.Exception inner) { }
        public virtual int ErrorCode { get { return default(int); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FieldOffsetAttribute : System.Attribute
    {
        public FieldOffsetAttribute(int offset) { }
        public int Value { get { return default(int); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct GCHandle
    {
        public bool IsAllocated { get { return default(bool); } }
        public object Target { [System.Security.SecurityCriticalAttribute]get { return default(object); } [System.Security.SecurityCriticalAttribute]set { } }
        [System.Security.SecurityCriticalAttribute]
        public System.IntPtr AddrOfPinnedObject() { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.InteropServices.GCHandle Alloc(object value) { return default(System.Runtime.InteropServices.GCHandle); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.InteropServices.GCHandle Alloc(object value, System.Runtime.InteropServices.GCHandleType type) { return default(System.Runtime.InteropServices.GCHandle); }
        public override bool Equals(object o) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public void Free() { }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.InteropServices.GCHandle FromIntPtr(System.IntPtr value) { return default(System.Runtime.InteropServices.GCHandle); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public static explicit operator System.Runtime.InteropServices.GCHandle (System.IntPtr value) { return default(System.Runtime.InteropServices.GCHandle); }
        public static explicit operator System.IntPtr (System.Runtime.InteropServices.GCHandle value) { return default(System.IntPtr); }
        public static bool operator !=(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { return default(bool); }
        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle value) { return default(System.IntPtr); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum GCHandleType
    {
        Normal = 2,
        Pinned = 3,
        Weak = 0,
        WeakTrackResurrection = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5149), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GuidAttribute : System.Attribute
    {
        public GuidAttribute(string guid) { }
        public string Value { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ICustomAdapter
    {
        object GetUnderlyingObject();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface ICustomQueryInterface
    {
        [System.Security.SecurityCriticalAttribute]
        System.Runtime.InteropServices.CustomQueryInterfaceResult GetInterface(ref System.Guid iid, out System.IntPtr ppv);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class InAttribute : System.Attribute
    {
        public InAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1024), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class InterfaceTypeAttribute : System.Attribute
    {
        public InterfaceTypeAttribute(short interfaceType) { }
        public InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType interfaceType) { }
        public System.Runtime.InteropServices.ComInterfaceType Value { get { return default(System.Runtime.InteropServices.ComInterfaceType); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InvalidComObjectException : System.SystemException
    {
        public InvalidComObjectException() { }
        public InvalidComObjectException(string message) { }
        public InvalidComObjectException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InvalidOleVariantTypeException : System.SystemException
    {
        public InvalidOleVariantTypeException() { }
        public InvalidOleVariantTypeException(string message) { }
        public InvalidOleVariantTypeException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum LayoutKind
    {
        Auto = 3,
        Explicit = 2,
        Sequential = 0,
    }
    [System.Security.SecurityCriticalAttribute]
    public static partial class Marshal
    {
        public static readonly int SystemDefaultCharSize;
        public static readonly int SystemMaxDBCSCharSize;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static int AddRef(System.IntPtr pUnk) { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr AllocCoTaskMem(int cb) { return default(System.IntPtr); }
        
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr AllocHGlobal(int cb) { return default(System.IntPtr); }
        
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr AllocHGlobal(System.IntPtr cb) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static bool AreComObjectsAvailableForCleanup() { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(byte[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(char[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(double[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(short[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(int[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(long[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, byte[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, char[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, double[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, short[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, int[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, long[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, System.IntPtr[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr source, float[] destination, int startIndex, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(System.IntPtr[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Security.SecurityCriticalAttribute]
        public static void Copy(float[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static System.IntPtr CreateAggregatedObject(System.IntPtr pOuter, object o) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr CreateAggregatedObject<T>(System.IntPtr pOuter, T o) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static object CreateWrapperOfType(object o, System.Type t) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static TWrapper CreateWrapperOfType<T, TWrapper>(T o) { return default(TWrapper); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public static void DestroyStructure(System.IntPtr ptr, System.Type structuretype) { }
        [System.Security.SecurityCriticalAttribute]
        public static void DestroyStructure<T>(System.IntPtr ptr) { }
        [System.Security.SecurityCriticalAttribute]
        public static int FinalReleaseComObject(object o) { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static void FreeBSTR(System.IntPtr ptr) { }
        [System.Security.SecurityCriticalAttribute]
        public static void FreeCoTaskMem(System.IntPtr ptr) { }
        
        [System.Security.SecurityCriticalAttribute]
        public static void FreeHGlobal(System.IntPtr hglobal) { }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T, System.Runtime.InteropServices.CustomQueryInterfaceMode mode) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetComInterfaceForObject<T, TInterface>(T o) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Delegate GetDelegateForFunctionPointer(System.IntPtr ptr, System.Type t) { return default(System.Delegate); }
        [System.Security.SecurityCriticalAttribute]
        public static TDelegate GetDelegateForFunctionPointer<TDelegate>(System.IntPtr ptr) { return default(TDelegate); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static int GetExceptionCode() { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Exception GetExceptionForHR(int errorCode) { return default(System.Exception); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Exception GetExceptionForHR(int errorCode, System.IntPtr errorInfo) { return default(System.Exception); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetFunctionPointerForDelegate(System.Delegate d) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static int GetHRForException(System.Exception e) { return default(int); }
        
        [System.Security.SecurityCriticalAttribute]
        public static int GetHRForLastWin32Error() { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetIUnknownForObject(object o) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecurityCriticalAttribute]
        public static int GetLastWin32Error() { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static void GetNativeVariantForObject(object obj, System.IntPtr pDstNativeVariant) { }
        [System.Security.SecurityCriticalAttribute]
        public static void GetNativeVariantForObject<T>(T obj, System.IntPtr pDstNativeVariant) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static object GetObjectForIUnknown(System.IntPtr pUnk) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static object GetObjectForNativeVariant(System.IntPtr pSrcNativeVariant) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static T GetObjectForNativeVariant<T>(System.IntPtr pSrcNativeVariant) { return default(T); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static object[] GetObjectsForNativeVariants(System.IntPtr aSrcNativeVariant, int cVars) { return default(object[]); }
        [System.Security.SecurityCriticalAttribute]
        public static T[] GetObjectsForNativeVariants<T>(System.IntPtr aSrcNativeVariant, int cVars) { return default(T[]); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static int GetStartComSlot(System.Type t) { return default(int); }
        public static System.Type GetTypeFromCLSID(System.Guid clsid) { return default(System.Type); }
        [System.Security.SecurityCriticalAttribute]
        public static string GetTypeInfoName(System.Runtime.InteropServices.ComTypes.ITypeInfo typeInfo) { return default(string); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static object GetUniqueObjectForIUnknown(System.IntPtr unknown) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public static bool IsComObject(object o) { return default(bool); }
        public static System.IntPtr OffsetOf(System.Type t, string fieldName) { return default(System.IntPtr); }
        public static System.IntPtr OffsetOf<T>(string fieldName) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static void Prelink(System.Reflection.MethodInfo m) { }
        [System.Security.SecurityCriticalAttribute]
        public static void PrelinkAll(System.Type c) { }
        [System.Security.SecurityCriticalAttribute]
        public static string PtrToStringAnsi(System.IntPtr ptr) { return default(string); }
        [System.Security.SecurityCriticalAttribute]
        public static string PtrToStringAnsi(System.IntPtr ptr, int len) { return default(string); }
        [System.Security.SecurityCriticalAttribute]
        public static string PtrToStringBSTR(System.IntPtr ptr) { return default(string); }
        [System.Security.SecurityCriticalAttribute]
        public static string PtrToStringUni(System.IntPtr ptr) { return default(string); }
        [System.Security.SecurityCriticalAttribute]
        public static string PtrToStringUni(System.IntPtr ptr, int len) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public static void PtrToStructure(System.IntPtr ptr, object structure) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public static object PtrToStructure(System.IntPtr ptr, System.Type structureType) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static T PtrToStructure<T>(System.IntPtr ptr) { return default(T); }
        [System.Security.SecurityCriticalAttribute]
        public static void PtrToStructure<T>(System.IntPtr ptr, T structure) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static int QueryInterface(System.IntPtr pUnk, ref System.Guid iid, out System.IntPtr ppv) { ppv = default(System.IntPtr); return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static byte ReadByte(System.IntPtr ptr) { return default(byte); }
        [System.Security.SecurityCriticalAttribute]
        public static byte ReadByte(System.IntPtr ptr, int ofs) { return default(byte); }
        [System.Security.SecurityCriticalAttribute]
        public static byte ReadByte(object ptr, int ofs) { return default(byte); }
        [System.Security.SecurityCriticalAttribute]
        public static short ReadInt16(System.IntPtr ptr) { return default(short); }
        [System.Security.SecurityCriticalAttribute]
        public static short ReadInt16(System.IntPtr ptr, int ofs) { return default(short); }
        [System.Security.SecurityCriticalAttribute]
        public static short ReadInt16(object ptr, int ofs) { return default(short); }
        
        [System.Security.SecurityCriticalAttribute]
        public static int ReadInt32(System.IntPtr ptr) { return default(int); }
        
        [System.Security.SecurityCriticalAttribute]
        public static int ReadInt32(System.IntPtr ptr, int ofs) { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static int ReadInt32(object ptr, int ofs) { return default(int); }
        
        [System.Security.SecurityCriticalAttribute]
        public static long ReadInt64(System.IntPtr ptr) { return default(long); }
        [System.Security.SecurityCriticalAttribute]
        public static long ReadInt64(System.IntPtr ptr, int ofs) { return default(long); }
        [System.Security.SecurityCriticalAttribute]
        public static long ReadInt64(object ptr, int ofs) { return default(long); }
        
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr) { return default(System.IntPtr); }
        
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr, int ofs) { return default(System.IntPtr); }
        
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr ReadIntPtr(object ptr, int ofs) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr ReAllocCoTaskMem(System.IntPtr pv, int cb) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr ReAllocHGlobal(System.IntPtr pv, System.IntPtr cb) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecurityCriticalAttribute]
        public static int Release(System.IntPtr pUnk) { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static int ReleaseComObject(object o) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static int SizeOf(object structure) { return default(int); }
        public static int SizeOf(System.Type t) { return default(int); }
        public static int SizeOf<T>() { return default(int); }
        public static int SizeOf<T>(T structure) { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr StringToBSTR(string s) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr StringToCoTaskMemAnsi(string s) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr StringToCoTaskMemUni(string s) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr StringToHGlobalAnsi(string s) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr StringToHGlobalUni(string s) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecurityCriticalAttribute]
        public static void StructureToPtr(object structure, System.IntPtr ptr, bool fDeleteOld) { }
        [System.Security.SecurityCriticalAttribute]
        public static void StructureToPtr<T>(T structure, System.IntPtr ptr, bool fDeleteOld) { }
        [System.Security.SecurityCriticalAttribute]
        public static void ThrowExceptionForHR(int errorCode) { }
        [System.Security.SecurityCriticalAttribute]
        public static void ThrowExceptionForHR(int errorCode, System.IntPtr errorInfo) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecurityCriticalAttribute]
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement(System.Array arr, int index) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteByte(System.IntPtr ptr, byte val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteByte(System.IntPtr ptr, int ofs, byte val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteByte(object ptr, int ofs, byte val) { ptr = default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt16(System.IntPtr ptr, char val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt16(System.IntPtr ptr, short val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt16(System.IntPtr ptr, int ofs, char val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt16(System.IntPtr ptr, int ofs, short val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt16(object ptr, int ofs, char val) { ptr = default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt16(object ptr, int ofs, short val) { ptr = default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt32(System.IntPtr ptr, int val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt32(System.IntPtr ptr, int ofs, int val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt32(object ptr, int ofs, int val) { ptr = default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt64(System.IntPtr ptr, int ofs, long val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt64(System.IntPtr ptr, long val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteInt64(object ptr, int ofs, long val) { ptr = default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteIntPtr(System.IntPtr ptr, int ofs, System.IntPtr val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteIntPtr(System.IntPtr ptr, System.IntPtr val) { }
        [System.Security.SecurityCriticalAttribute]
        public static void WriteIntPtr(object ptr, int ofs, System.IntPtr val) { ptr = default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static void ZeroFreeBSTR(System.IntPtr s) { }
        [System.Security.SecurityCriticalAttribute]
        public static void ZeroFreeCoTaskMemAnsi(System.IntPtr s) { }
        [System.Security.SecurityCriticalAttribute]
        public static void ZeroFreeCoTaskMemUnicode(System.IntPtr s) { }
        [System.Security.SecurityCriticalAttribute]
        public static void ZeroFreeGlobalAllocAnsi(System.IntPtr s) { }
        [System.Security.SecurityCriticalAttribute]
        public static void ZeroFreeGlobalAllocUnicode(System.IntPtr s) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10496), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class MarshalAsAttribute : System.Attribute
    {
        public System.Runtime.InteropServices.UnmanagedType ArraySubType;
        public int IidParameterIndex;
        public string MarshalCookie;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public string MarshalType;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Type MarshalTypeRef;
        public System.Runtime.InteropServices.VarEnum SafeArraySubType;
        public System.Type SafeArrayUserDefinedSubType;
        public int SizeConst;
        public short SizeParamIndex;
        public MarshalAsAttribute(short unmanagedType) { }
        public MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType unmanagedType) { }
        public System.Runtime.InteropServices.UnmanagedType Value { get { return default(System.Runtime.InteropServices.UnmanagedType); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MarshalDirectiveException : System.SystemException
    {
        public MarshalDirectiveException() { }
        public MarshalDirectiveException(string message) { }
        public MarshalDirectiveException(string message, System.Exception inner) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class NativeCallableAttribute : System.Attribute
    {
        public System.Runtime.InteropServices.CallingConvention CallingConvention;
        public string EntryPoint;
        public NativeCallableAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OptionalAttribute : System.Attribute
    {
        public OptionalAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OutAttribute : System.Attribute
    {
        public OutAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PreserveSigAttribute : System.Attribute
    {
        public PreserveSigAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class RuntimeEnvironment
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static string GetRuntimeDirectory() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SafeArrayRankMismatchException : System.SystemException
    {
        public SafeArrayRankMismatchException() { }
        public SafeArrayRankMismatchException(string message) { }
        public SafeArrayRankMismatchException(string message, System.Exception inner) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SafeArrayTypeMismatchException : System.SystemException
    {
        public SafeArrayTypeMismatchException() { }
        public SafeArrayTypeMismatchException(string message) { }
        public SafeArrayTypeMismatchException(string message, System.Exception inner) { }
    }
    [System.Security.SecurityCriticalAttribute]
    public abstract partial class SafeBuffer : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        protected SafeBuffer(bool ownsHandle) { }
        [System.CLSCompliantAttribute(false)]
        public ulong ByteLength { get { return default(ulong); } }
        [System.CLSCompliantAttribute(false)]
        
        public unsafe void AcquirePointer(ref byte* pointer) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize(uint numElements, uint sizeOfEachElement) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize(ulong numBytes) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize<T>(uint numElements) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        
        public T Read<T>(ulong byteOffset) where T : struct { return default(T); }
        [System.CLSCompliantAttribute(false)]
        
        public void ReadArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct { }
        
        public void ReleasePointer() { }
        [System.CLSCompliantAttribute(false)]
        
        public void Write<T>(ulong byteOffset, T value) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        
        public void WriteArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct { }
    }
    [System.Security.SecurityCriticalAttribute]
    public abstract partial class SafeHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
    {
        protected System.IntPtr handle;
        protected SafeHandle() { }
        
        protected SafeHandle(System.IntPtr invalidHandleValue, bool ownsHandle) { }
        public bool IsClosed { get { return default(bool); } }
        public abstract bool IsInvalid { get; }
        
        [System.Security.SecurityCriticalAttribute]
        public void Close() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecurityCriticalAttribute]
        public void DangerousAddRef(ref bool success) { }
        
        public System.IntPtr DangerousGetHandle() { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecurityCriticalAttribute]
        public void DangerousRelease() { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public void Dispose() { }
        
        [System.Security.SecurityCriticalAttribute]
        protected virtual void Dispose(bool disposing) { }
        ~SafeHandle() { }
        
        protected abstract bool ReleaseHandle();
        
        protected void SetHandle(System.IntPtr handle) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecurityCriticalAttribute]
        public void SetHandleAsInvalid() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SEHException : System.Runtime.InteropServices.ExternalException
    {
        public SEHException() { }
        public SEHException(string message) { }
        public SEHException(string message, System.Exception inner) { }
        public virtual bool CanResume() { return default(bool); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StructLayoutAttribute : System.Attribute
    {
        public System.Runtime.InteropServices.CharSet CharSet;
        public int Pack;
        public int Size;
        public StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind layoutKind) { }
        public System.Runtime.InteropServices.LayoutKind Value { get { return default(System.Runtime.InteropServices.LayoutKind); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5144), AllowMultiple=false, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class TypeIdentifierAttribute : System.Attribute
    {
        public TypeIdentifierAttribute() { }
        public TypeIdentifierAttribute(string scope, string identifier) { }
        public string Identifier { get { return default(string); } }
        public string Scope { get { return default(string); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UnknownWrapper
    {
        public UnknownWrapper(object obj) { }
        public object WrappedObject { get { return default(object); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4096), AllowMultiple=false, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UnmanagedFunctionPointerAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CharSet CharSet;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention callingConvention) { }
        public System.Runtime.InteropServices.CallingConvention CallingConvention { get { return default(System.Runtime.InteropServices.CallingConvention); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum UnmanagedType
    {
        AnsiBStr = 35,
        AsAny = 40,
        Bool = 2,
        BStr = 19,
        ByValArray = 30,
        ByValTStr = 23,
        Currency = 15,
        CustomMarshaler = 44,
        Error = 45,
        FunctionPtr = 38,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        HString = 47,
        I1 = 3,
        I2 = 5,
        I4 = 7,
        I8 = 9,
        IDispatch = 26,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        IInspectable = 46,
        Interface = 28,
        IUnknown = 25,
        LPArray = 42,
        LPStr = 20,
        LPStruct = 43,
        LPTStr = 22,
        LPWStr = 21,
        R4 = 11,
        R8 = 12,
        SafeArray = 29,
        Struct = 27,
        SysInt = 31,
        SysUInt = 32,
        TBStr = 36,
        U1 = 4,
        U2 = 6,
        U4 = 8,
        U8 = 10,
        VariantBool = 37,
        VBByRefStr = 34,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum VarEnum
    {
        VT_ARRAY = 8192,
        VT_BLOB = 65,
        VT_BLOB_OBJECT = 70,
        VT_BOOL = 11,
        VT_BSTR = 8,
        VT_BYREF = 16384,
        VT_CARRAY = 28,
        VT_CF = 71,
        VT_CLSID = 72,
        VT_CY = 6,
        VT_DATE = 7,
        VT_DECIMAL = 14,
        VT_DISPATCH = 9,
        VT_EMPTY = 0,
        VT_ERROR = 10,
        VT_FILETIME = 64,
        VT_HRESULT = 25,
        VT_I1 = 16,
        VT_I2 = 2,
        VT_I4 = 3,
        VT_I8 = 20,
        VT_INT = 22,
        VT_LPSTR = 30,
        VT_LPWSTR = 31,
        VT_NULL = 1,
        VT_PTR = 26,
        VT_R4 = 4,
        VT_R8 = 5,
        VT_RECORD = 36,
        VT_SAFEARRAY = 27,
        VT_STORAGE = 67,
        VT_STORED_OBJECT = 69,
        VT_STREAM = 66,
        VT_STREAMED_OBJECT = 68,
        VT_UI1 = 17,
        VT_UI2 = 18,
        VT_UI4 = 19,
        VT_UI8 = 21,
        VT_UINT = 23,
        VT_UNKNOWN = 13,
        VT_USERDEFINED = 29,
        VT_VARIANT = 12,
        VT_VECTOR = 4096,
        VT_VOID = 24,
    }
    public sealed partial class VariantWrapper
    {
        public VariantWrapper(object obj) { }
        public object WrappedObject { get { return default(object); } }
    }
}
namespace System.Runtime.InteropServices.ComTypes
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BIND_OPTS
    {
        public int cbStruct;
        public int dwTickCountDeadline;
        public int grfFlags;
        public int grfMode;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public partial struct BINDPTR
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpfuncdesc;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lptcomp;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpvardesc;
    }
    public enum CALLCONV
    {
        CC_CDECL = 1,
        CC_MACPASCAL = 3,
        CC_MAX = 9,
        CC_MPWCDECL = 7,
        CC_MPWPASCAL = 8,
        CC_MSCPASCAL = 2,
        CC_PASCAL = 2,
        CC_RESERVED = 5,
        CC_STDCALL = 4,
        CC_SYSCALL = 6,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CONNECTDATA
    {
        public int dwCookie;
        public object pUnk;
    }
    public enum DESCKIND
    {
        DESCKIND_FUNCDESC = 1,
        DESCKIND_IMPLICITAPPOBJ = 4,
        DESCKIND_MAX = 5,
        DESCKIND_NONE = 0,
        DESCKIND_TYPECOMP = 3,
        DESCKIND_VARDESC = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DISPPARAMS
    {
        public int cArgs;
        public int cNamedArgs;
        public System.IntPtr rgdispidNamedArgs;
        public System.IntPtr rgvarg;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ELEMDESC
    {
        public System.Runtime.InteropServices.ComTypes.ELEMDESC.DESCUNION desc;
        public System.Runtime.InteropServices.ComTypes.TYPEDESC tdesc;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.ComTypes.IDLDESC idldesc;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.ComTypes.PARAMDESC paramdesc;
        }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EXCEPINFO
    {
        public string bstrDescription;
        public string bstrHelpFile;
        public string bstrSource;
        public int dwHelpContext;
        public System.IntPtr pfnDeferredFillIn;
        public System.IntPtr pvReserved;
        public int scode;
        public short wCode;
        public short wReserved;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FILETIME
    {
        public int dwHighDateTime;
        public int dwLowDateTime;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FUNCDESC
    {
        public System.Runtime.InteropServices.ComTypes.CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short cScodes;
        public System.Runtime.InteropServices.ComTypes.ELEMDESC elemdescFunc;
        public System.Runtime.InteropServices.ComTypes.FUNCKIND funckind;
        public System.Runtime.InteropServices.ComTypes.INVOKEKIND invkind;
        public System.IntPtr lprgelemdescParam;
        public System.IntPtr lprgscode;
        public int memid;
        public short oVft;
        public short wFuncFlags;
    }
    [System.FlagsAttribute]
    public enum FUNCFLAGS : short
    {
        FUNCFLAG_FBINDABLE = (short)4,
        FUNCFLAG_FDEFAULTBIND = (short)32,
        FUNCFLAG_FDEFAULTCOLLELEM = (short)256,
        FUNCFLAG_FDISPLAYBIND = (short)16,
        FUNCFLAG_FHIDDEN = (short)64,
        FUNCFLAG_FIMMEDIATEBIND = (short)4096,
        FUNCFLAG_FNONBROWSABLE = (short)1024,
        FUNCFLAG_FREPLACEABLE = (short)2048,
        FUNCFLAG_FREQUESTEDIT = (short)8,
        FUNCFLAG_FRESTRICTED = (short)1,
        FUNCFLAG_FSOURCE = (short)2,
        FUNCFLAG_FUIDEFAULT = (short)512,
        FUNCFLAG_FUSESGETLASTERROR = (short)128,
    }
    public enum FUNCKIND
    {
        FUNC_DISPATCH = 4,
        FUNC_NONVIRTUAL = 2,
        FUNC_PUREVIRTUAL = 1,
        FUNC_STATIC = 3,
        FUNC_VIRTUAL = 0,
    }
    [System.Runtime.InteropServices.GuidAttribute("0000000e-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IBindCtx
    {
        void EnumObjectParam(out System.Runtime.InteropServices.ComTypes.IEnumString ppenum);
        void GetBindOptions(ref System.Runtime.InteropServices.ComTypes.BIND_OPTS pbindopts);
        void GetObjectParam(string pszKey, out object ppunk);
        void GetRunningObjectTable(out System.Runtime.InteropServices.ComTypes.IRunningObjectTable pprot);
        void RegisterObjectBound(object punk);
        void RegisterObjectParam(string pszKey, object punk);
        void ReleaseBoundObjects();
        void RevokeObjectBound(object punk);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int RevokeObjectParam(string pszKey);
        void SetBindOptions(ref System.Runtime.InteropServices.ComTypes.BIND_OPTS pbindopts);
    }
    [System.Runtime.InteropServices.GuidAttribute("B196B286-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IConnectionPoint
    {
        void Advise(object pUnkSink, out int pdwCookie);
        void EnumConnections(out System.Runtime.InteropServices.ComTypes.IEnumConnections ppEnum);
        void GetConnectionInterface(out System.Guid pIID);
        void GetConnectionPointContainer(out System.Runtime.InteropServices.ComTypes.IConnectionPointContainer ppCPC);
        void Unadvise(int dwCookie);
    }
    [System.Runtime.InteropServices.GuidAttribute("B196B284-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IConnectionPointContainer
    {
        void EnumConnectionPoints(out System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppEnum);
        void FindConnectionPoint(ref System.Guid riid, out System.Runtime.InteropServices.ComTypes.IConnectionPoint ppCP);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IDLDESC
    {
        public System.IntPtr dwReserved;
        public System.Runtime.InteropServices.ComTypes.IDLFLAG wIDLFlags;
    }
    [System.FlagsAttribute]
    public enum IDLFLAG : short
    {
        IDLFLAG_FIN = (short)1,
        IDLFLAG_FLCID = (short)4,
        IDLFLAG_FOUT = (short)2,
        IDLFLAG_FRETVAL = (short)8,
        IDLFLAG_NONE = (short)0,
    }
    [System.Runtime.InteropServices.GuidAttribute("B196B285-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumConnectionPoints
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppenum);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Next(int celt, System.Runtime.InteropServices.ComTypes.IConnectionPoint[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Skip(int celt);
    }
    [System.Runtime.InteropServices.GuidAttribute("B196B287-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumConnections
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumConnections ppenum);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Next(int celt, System.Runtime.InteropServices.ComTypes.CONNECTDATA[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Skip(int celt);
    }
    [System.Runtime.InteropServices.GuidAttribute("00000102-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumMoniker
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenum);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Next(int celt, System.Runtime.InteropServices.ComTypes.IMoniker[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Skip(int celt);
    }
    [System.Runtime.InteropServices.GuidAttribute("00000101-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumString
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumString ppenum);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Next(int celt, string[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Skip(int celt);
    }
    [System.Runtime.InteropServices.GuidAttribute("00020404-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumVARIANT
    {
        System.Runtime.InteropServices.ComTypes.IEnumVARIANT Clone();
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Next(int celt, object[] rgVar, System.IntPtr pceltFetched);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Reset();
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int Skip(int celt);
    }
    [System.Runtime.InteropServices.GuidAttribute("0000000f-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IMoniker
    {
        void BindToObject(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, ref System.Guid riidResult, out object ppvResult);
        void BindToStorage(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, ref System.Guid riid, out object ppvObj);
        void CommonPrefixWith(System.Runtime.InteropServices.ComTypes.IMoniker pmkOther, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkPrefix);
        void ComposeWith(System.Runtime.InteropServices.ComTypes.IMoniker pmkRight, bool fOnlyIfNotGeneric, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkComposite);
        void Enum(bool fForward, out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMoniker);
        void GetClassID(out System.Guid pClassID);
        void GetDisplayName(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, out string ppszDisplayName);
        void GetSizeMax(out long pcbSize);
        void GetTimeOfLastChange(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, out System.Runtime.InteropServices.ComTypes.FILETIME pFileTime);
        void Hash(out int pdwHash);
        void Inverse(out System.Runtime.InteropServices.ComTypes.IMoniker ppmk);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int IsDirty();
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int IsEqual(System.Runtime.InteropServices.ComTypes.IMoniker pmkOtherMoniker);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int IsRunning(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, System.Runtime.InteropServices.ComTypes.IMoniker pmkNewlyRunning);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int IsSystemMoniker(out int pdwMksys);
        void Load(System.Runtime.InteropServices.ComTypes.IStream pStm);
        void ParseDisplayName(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, string pszDisplayName, out int pchEaten, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkOut);
        void Reduce(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, int dwReduceHowFar, ref System.Runtime.InteropServices.ComTypes.IMoniker ppmkToLeft, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkReduced);
        void RelativePathTo(System.Runtime.InteropServices.ComTypes.IMoniker pmkOther, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkRelPath);
        void Save(System.Runtime.InteropServices.ComTypes.IStream pStm, bool fClearDirty);
    }
    [System.FlagsAttribute]
    public enum IMPLTYPEFLAGS
    {
        IMPLTYPEFLAG_FDEFAULT = 1,
        IMPLTYPEFLAG_FDEFAULTVTABLE = 8,
        IMPLTYPEFLAG_FRESTRICTED = 4,
        IMPLTYPEFLAG_FSOURCE = 2,
    }
    [System.FlagsAttribute]
    public enum INVOKEKIND
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8,
    }
    [System.Runtime.InteropServices.GuidAttribute("0000010b-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IPersistFile
    {
        void GetClassID(out System.Guid pClassID);
        void GetCurFile(out string ppszFileName);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int IsDirty();
        void Load(string pszFileName, int dwMode);
        void Save(string pszFileName, bool fRemember);
        void SaveCompleted(string pszFileName);
    }
    [System.Runtime.InteropServices.GuidAttribute("00000010-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IRunningObjectTable
    {
        void EnumRunning(out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMoniker);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int GetObject(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName, out object ppunkObject);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int GetTimeOfLastChange(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName, out System.Runtime.InteropServices.ComTypes.FILETIME pfiletime);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int IsRunning(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName);
        void NoteChangeTime(int dwRegister, ref System.Runtime.InteropServices.ComTypes.FILETIME pfiletime);
        int Register(int grfFlags, object punkObject, System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName);
        void Revoke(int dwRegister);
    }
    [System.Runtime.InteropServices.GuidAttribute("0000000c-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IStream
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IStream ppstm);
        void Commit(int grfCommitFlags);
        void CopyTo(System.Runtime.InteropServices.ComTypes.IStream pstm, long cb, System.IntPtr pcbRead, System.IntPtr pcbWritten);
        void LockRegion(long libOffset, long cb, int dwLockType);
        void Read(byte[] pv, int cb, System.IntPtr pcbRead);
        void Revert();
        void Seek(long dlibMove, int dwOrigin, System.IntPtr plibNewPosition);
        void SetSize(long libNewSize);
        void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag);
        void UnlockRegion(long libOffset, long cb, int dwLockType);
        void Write(byte[] pv, int cb, System.IntPtr pcbWritten);
    }
    [System.Runtime.InteropServices.GuidAttribute("00020403-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeComp
    {
        void Bind(string szName, int lHashVal, short wFlags, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo, out System.Runtime.InteropServices.ComTypes.DESCKIND pDescKind, out System.Runtime.InteropServices.ComTypes.BINDPTR pBindPtr);
        void BindType(string szName, int lHashVal, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo, out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
    }
    [System.Runtime.InteropServices.GuidAttribute("00020401-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeInfo
    {
        void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
        void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
        void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
        void GetMops(int memid, out string pBstrMops);
        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetRefTypeInfo(int hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        void GetRefTypeOfImplType(int index, out int href);
        void GetTypeAttr(out System.IntPtr ppTypeAttr);
        void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]void ReleaseVarDesc(System.IntPtr pVarDesc);
    }
    [System.Runtime.InteropServices.GuidAttribute("00020412-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeInfo2 : System.Runtime.InteropServices.ComTypes.ITypeInfo
    {
        new void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
        new void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetAllCustData(System.IntPtr pCustData);
        void GetAllFuncCustData(int index, System.IntPtr pCustData);
        void GetAllImplTypeCustData(int index, System.IntPtr pCustData);
        void GetAllParamCustData(int indexFunc, int indexParam, System.IntPtr pCustData);
        void GetAllVarCustData(int index, System.IntPtr pCustData);
        new void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
        void GetCustData(ref System.Guid guid, out object pVarVal);
        new void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
        new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetDocumentation2(int memid, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
        void GetFuncCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetFuncIndexOfMemId(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out int pFuncIndex);
        new void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
        new void GetMops(int memid, out string pBstrMops);
        new void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetParamCustData(int indexFunc, int indexParam, ref System.Guid guid, out object pVarVal);
        new void GetRefTypeInfo(int hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        new void GetRefTypeOfImplType(int index, out int href);
        new void GetTypeAttr(out System.IntPtr ppTypeAttr);
        new void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetTypeFlags(out int pTypeFlags);
        void GetTypeKind(out System.Runtime.InteropServices.ComTypes.TYPEKIND pTypeKind);
        void GetVarCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void GetVarIndexOfMemId(int memid, out int pVarIndex);
        new void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]new void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]new void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]new void ReleaseVarDesc(System.IntPtr pVarDesc);
    }
    [System.Runtime.InteropServices.GuidAttribute("00020402-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeLib
    {
        void FindName(string szNameBuf, int lHashVal, System.Runtime.InteropServices.ComTypes.ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetLibAttr(out System.IntPtr ppTLibAttr);
        void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetTypeInfo(int index, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]int GetTypeInfoCount();
        void GetTypeInfoOfGuid(ref System.Guid guid, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo);
        void GetTypeInfoType(int index, out System.Runtime.InteropServices.ComTypes.TYPEKIND pTKind);
        bool IsName(string szNameBuf, int lHashVal);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]void ReleaseTLibAttr(System.IntPtr pTLibAttr);
    }
    [System.Runtime.InteropServices.GuidAttribute("00020411-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeLib2 : System.Runtime.InteropServices.ComTypes.ITypeLib
    {
        new void FindName(string szNameBuf, int lHashVal, System.Runtime.InteropServices.ComTypes.ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        void GetAllCustData(System.IntPtr pCustData);
        void GetCustData(ref System.Guid guid, out object pVarVal);
        new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        
        void GetDocumentation2(int index, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
        new void GetLibAttr(out System.IntPtr ppTLibAttr);
        void GetLibStatistics(System.IntPtr pcUniqueNames, out int pcchUniqueNames);
        new void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        new void GetTypeInfo(int index, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]new int GetTypeInfoCount();
        new void GetTypeInfoOfGuid(ref System.Guid guid, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo);
        new void GetTypeInfoType(int index, out System.Runtime.InteropServices.ComTypes.TYPEKIND pTKind);
        new bool IsName(string szNameBuf, int lHashVal);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]new void ReleaseTLibAttr(System.IntPtr pTLibAttr);
    }
    [System.FlagsAttribute]
    public enum LIBFLAGS : short
    {
        LIBFLAG_FCONTROL = (short)2,
        LIBFLAG_FHASDISKIMAGE = (short)8,
        LIBFLAG_FHIDDEN = (short)4,
        LIBFLAG_FRESTRICTED = (short)1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PARAMDESC
    {
        public System.IntPtr lpVarValue;
        public System.Runtime.InteropServices.ComTypes.PARAMFLAG wParamFlags;
    }
    [System.FlagsAttribute]
    public enum PARAMFLAG : short
    {
        PARAMFLAG_FHASCUSTDATA = (short)64,
        PARAMFLAG_FHASDEFAULT = (short)32,
        PARAMFLAG_FIN = (short)1,
        PARAMFLAG_FLCID = (short)4,
        PARAMFLAG_FOPT = (short)16,
        PARAMFLAG_FOUT = (short)2,
        PARAMFLAG_FRETVAL = (short)8,
        PARAMFLAG_NONE = (short)0,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct STATSTG
    {
        public System.Runtime.InteropServices.ComTypes.FILETIME atime;
        public long cbSize;
        public System.Guid clsid;
        public System.Runtime.InteropServices.ComTypes.FILETIME ctime;
        public int grfLocksSupported;
        public int grfMode;
        public int grfStateBits;
        public System.Runtime.InteropServices.ComTypes.FILETIME mtime;
        public string pwcsName;
        public int reserved;
        public int type;
    }
    public enum SYSKIND
    {
        SYS_MAC = 2,
        SYS_WIN16 = 0,
        SYS_WIN32 = 1,
        SYS_WIN64 = 3,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEATTR
    {
        public short cbAlignment;
        public int cbSizeInstance;
        public short cbSizeVft;
        public short cFuncs;
        public short cImplTypes;
        public short cVars;
        public int dwReserved;
        public System.Guid guid;
        public System.Runtime.InteropServices.ComTypes.IDLDESC idldescType;
        public int lcid;
        public System.IntPtr lpstrSchema;
        public const int MEMBER_ID_NIL = -1;
        public int memidConstructor;
        public int memidDestructor;
        public System.Runtime.InteropServices.ComTypes.TYPEDESC tdescAlias;
        public System.Runtime.InteropServices.ComTypes.TYPEKIND typekind;
        public short wMajorVerNum;
        public short wMinorVerNum;
        public System.Runtime.InteropServices.ComTypes.TYPEFLAGS wTypeFlags;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEDESC
    {
        public System.IntPtr lpValue;
        public short vt;
    }
    [System.FlagsAttribute]
    public enum TYPEFLAGS : short
    {
        TYPEFLAG_FAGGREGATABLE = (short)1024,
        TYPEFLAG_FAPPOBJECT = (short)1,
        TYPEFLAG_FCANCREATE = (short)2,
        TYPEFLAG_FCONTROL = (short)32,
        TYPEFLAG_FDISPATCHABLE = (short)4096,
        TYPEFLAG_FDUAL = (short)64,
        TYPEFLAG_FHIDDEN = (short)16,
        TYPEFLAG_FLICENSED = (short)4,
        TYPEFLAG_FNONEXTENSIBLE = (short)128,
        TYPEFLAG_FOLEAUTOMATION = (short)256,
        TYPEFLAG_FPREDECLID = (short)8,
        TYPEFLAG_FPROXY = (short)16384,
        TYPEFLAG_FREPLACEABLE = (short)2048,
        TYPEFLAG_FRESTRICTED = (short)512,
        TYPEFLAG_FREVERSEBIND = (short)8192,
    }
    public enum TYPEKIND
    {
        TKIND_ALIAS = 6,
        TKIND_COCLASS = 5,
        TKIND_DISPATCH = 4,
        TKIND_ENUM = 0,
        TKIND_INTERFACE = 3,
        TKIND_MAX = 8,
        TKIND_MODULE = 2,
        TKIND_RECORD = 1,
        TKIND_UNION = 7,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPELIBATTR
    {
        public System.Guid guid;
        public int lcid;
        public System.Runtime.InteropServices.ComTypes.SYSKIND syskind;
        public System.Runtime.InteropServices.ComTypes.LIBFLAGS wLibFlags;
        public short wMajorVerNum;
        public short wMinorVerNum;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct VARDESC
    {
        public System.Runtime.InteropServices.ComTypes.VARDESC.DESCUNION desc;
        public System.Runtime.InteropServices.ComTypes.ELEMDESC elemdescVar;
        public string lpstrSchema;
        public int memid;
        public System.Runtime.InteropServices.ComTypes.VARKIND varkind;
        public short wVarFlags;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.IntPtr lpvarValue;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public int oInst;
        }
    }
    [System.FlagsAttribute]
    public enum VARFLAGS : short
    {
        VARFLAG_FBINDABLE = (short)4,
        VARFLAG_FDEFAULTBIND = (short)32,
        VARFLAG_FDEFAULTCOLLELEM = (short)256,
        VARFLAG_FDISPLAYBIND = (short)16,
        VARFLAG_FHIDDEN = (short)64,
        VARFLAG_FIMMEDIATEBIND = (short)4096,
        VARFLAG_FNONBROWSABLE = (short)1024,
        VARFLAG_FREADONLY = (short)1,
        VARFLAG_FREPLACEABLE = (short)2048,
        VARFLAG_FREQUESTEDIT = (short)8,
        VARFLAG_FRESTRICTED = (short)128,
        VARFLAG_FSOURCE = (short)2,
        VARFLAG_FUIDEFAULT = (short)512,
    }
    public enum VARKIND
    {
        VAR_CONST = 2,
        VAR_DISPATCH = 3,
        VAR_PERINSTANCE = 0,
        VAR_STATIC = 1,
    }
}
namespace System.Runtime.InteropServices.WindowsRuntime
{
#if FEATURE_COMINTEROP    
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=false, Inherited=false)]
    public sealed partial class DefaultInterfaceAttribute : System.Attribute
    {
        public DefaultInterfaceAttribute(System.Type defaultInterface) { }
        public System.Type DefaultInterface { get { return default(System.Type); } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EventRegistrationToken
    {
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken left, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken right) { return default(bool); }
        public static bool operator !=(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken left, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken right) { return default(bool); }
    }
    public sealed partial class EventRegistrationTokenTable<T> where T : class
    {
        public EventRegistrationTokenTable() { }
        public T InvocationList { get { return default(T); } set { } }
        public System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken AddEventHandler(T handler) { return default(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken); }
        public static System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> refEventTable) { return default(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>); }
        public void RemoveEventHandler(T handler) { }
        public void RemoveEventHandler(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken token) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("00000035-0000-0000-C000-000000000046")]
    public partial interface IActivationFactory
    {
        object ActivateInstance();
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), Inherited=false, AllowMultiple=true)]
    public sealed partial class InterfaceImplementedInVersionAttribute : System.Attribute
    {
        public InterfaceImplementedInVersionAttribute(System.Type interfaceType, byte majorVersion, byte minorVersion, byte buildVersion, byte revisionVersion) { }
        public byte BuildVersion { get { return default(byte); } }
        public System.Type InterfaceType { get { return default(System.Type); } }
        public byte MajorVersion { get { return default(byte); } }
        public byte MinorVersion { get { return default(byte); } }
        public byte RevisionVersion { get { return default(byte); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false, AllowMultiple=false)]
    public sealed partial class ReadOnlyArrayAttribute : System.Attribute
    {
        public ReadOnlyArrayAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12288), AllowMultiple=false, Inherited=false)]
    public sealed partial class ReturnValueNameAttribute : System.Attribute
    {
        public ReturnValueNameAttribute(string name) { }
        public string Name { get { return default(string); } }
    }
    public static partial class WindowsRuntimeMarshal
    {
        [System.Security.SecurityCriticalAttribute]
        public static void AddEventHandler<T>(System.Func<T, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> addMethod, System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod, T handler) { }
        [System.Security.SecurityCriticalAttribute]
        public static void FreeHString(System.IntPtr ptr) { }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.InteropServices.WindowsRuntime.IActivationFactory GetActivationFactory(System.Type type) { return default(System.Runtime.InteropServices.WindowsRuntime.IActivationFactory); }
        [System.Security.SecurityCriticalAttribute]
        public static string PtrToStringHString(System.IntPtr ptr) { return default(string); }
        [System.Security.SecurityCriticalAttribute]
        public static void RemoveAllEventHandlers(System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod) { }
        [System.Security.SecurityCriticalAttribute]
        public static void RemoveEventHandler<T>(System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod, T handler) { }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr StringToHString(string s) { return default(System.IntPtr); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false, AllowMultiple=false)]
    public sealed partial class WriteOnlyArrayAttribute : System.Attribute
    {
        public WriteOnlyArrayAttribute() { }
    }
#endif //FEATURE_COMINTEROP
}
namespace System.Runtime.Loader
{
    [System.Security.SecuritySafeCriticalAttribute]
    public abstract partial class AssemblyLoadContext
    {
        protected AssemblyLoadContext() { }
        public static System.Runtime.Loader.AssemblyLoadContext Default { get { return default(System.Runtime.Loader.AssemblyLoadContext); } }
        public event System.Func<System.Runtime.Loader.AssemblyLoadContext, System.Reflection.AssemblyName, System.Reflection.Assembly> Resolving { add { } remove { } }
        public event System.Action<System.Runtime.Loader.AssemblyLoadContext> Unloading { add { } remove { } }
        public static System.Reflection.AssemblyName GetAssemblyName(string assemblyPath) { return default(System.Reflection.AssemblyName); }
        public static System.Runtime.Loader.AssemblyLoadContext GetLoadContext(System.Reflection.Assembly assembly) { return default(System.Runtime.Loader.AssemblyLoadContext); }
        public static void InitializeDefaultContext(System.Runtime.Loader.AssemblyLoadContext context) { }
        protected abstract System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyName);
        public System.Reflection.Assembly LoadFromAssemblyName(System.Reflection.AssemblyName assemblyName) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly LoadFromAssemblyPath(string assemblyPath) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly LoadFromNativeImagePath(string nativeImagePath, string assemblyPath) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly LoadFromStream(System.IO.Stream assembly) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly LoadFromStream(System.IO.Stream assembly, System.IO.Stream assemblySymbols) { return default(System.Reflection.Assembly); }
        protected virtual System.IntPtr LoadUnmanagedDll(string unmanagedDllName) { return default(System.IntPtr); }
        protected System.IntPtr LoadUnmanagedDllFromPath(string unmanagedDllPath) { return default(System.IntPtr); }
        public void SetProfileOptimizationRoot(string directoryPath) { }
        public void StartProfileOptimization(string profile) { }
    }
}
namespace System.Runtime.Serialization
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class FormatterServices
    {
        [System.Security.SecurityCriticalAttribute]
        public static object GetUninitializedObject(System.Type type) { return default(object); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OnDeserializedAttribute : System.Attribute
    {
        public OnDeserializedAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OnDeserializingAttribute : System.Attribute
    {
        public OnDeserializingAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OnSerializedAttribute : System.Attribute
    {
        public OnSerializedAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OnSerializingAttribute : System.Attribute
    {
        public OnSerializingAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SerializationException : System.SystemException
    {
        public SerializationException() { }
        public SerializationException(string message) { }
        public SerializationException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct StreamingContext
    {
        public StreamingContext(System.Runtime.Serialization.StreamingContextStates state) { throw new System.NotImplementedException(); }
        public StreamingContext(System.Runtime.Serialization.StreamingContextStates state, object additional) { throw new System.NotImplementedException(); }
        public object Context { get { return default(object); } }
        public System.Runtime.Serialization.StreamingContextStates State { get { return default(System.Runtime.Serialization.StreamingContextStates); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum StreamingContextStates
    {
        All = 255,
        Clone = 64,
        CrossAppDomain = 128,
        CrossMachine = 2,
        CrossProcess = 1,
        File = 4,
        Other = 32,
        Persistence = 8,
        Remoting = 16,
    }
}
namespace System.Runtime.Versioning
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(5887), AllowMultiple=false, Inherited=false)]
    public sealed partial class ComponentGuaranteesAttribute : System.Attribute
    {
        public ComponentGuaranteesAttribute(System.Runtime.Versioning.ComponentGuaranteesOptions guarantees) { }
        public System.Runtime.Versioning.ComponentGuaranteesOptions Guarantees { get { return default(System.Runtime.Versioning.ComponentGuaranteesOptions); } }
    }
    [System.FlagsAttribute]
    public enum ComponentGuaranteesOptions
    {
        Exchange = 1,
        None = 0,
        SideBySide = 4,
        Stable = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(480), Inherited=false)]
    [System.Diagnostics.ConditionalAttribute("RESOURCE_ANNOTATION_WORK")]
    public sealed partial class ResourceExposureAttribute : System.Attribute
    {
        public ResourceExposureAttribute(System.Runtime.Versioning.ResourceScope exposureLevel) { }
        public System.Runtime.Versioning.ResourceScope ResourceExposureLevel { get { return default(System.Runtime.Versioning.ResourceScope); } }
    }
    [System.FlagsAttribute]
    public enum ResourceScope
    {
        AppDomain = 4,
        Assembly = 32,
        Library = 8,
        Machine = 1,
        None = 0,
        Private = 16,
        Process = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false, Inherited=false)]
    public sealed partial class TargetFrameworkAttribute : System.Attribute
    {
        public TargetFrameworkAttribute(string frameworkName) { }
        public string FrameworkDisplayName { get { return default(string); } set { } }
        public string FrameworkName { get { return default(string); } }
    }
    public static partial class VersioningHelper
    {
        public static string MakeVersionSafeName(string name, System.Runtime.Versioning.ResourceScope from, System.Runtime.Versioning.ResourceScope to) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string MakeVersionSafeName(string name, System.Runtime.Versioning.ResourceScope from, System.Runtime.Versioning.ResourceScope to, System.Type type) { return default(string); }
    }
}
namespace System.Security
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AllowPartiallyTrustedCallersAttribute : System.Attribute
    {
        public AllowPartiallyTrustedCallersAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5501), AllowMultiple=false, Inherited=false)]
    public sealed partial class SecurityCriticalAttribute : System.Attribute
    {
        public SecurityCriticalAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SecurityException : System.SystemException
    {
        public SecurityException() { }
        public SecurityException(string message) { }
        public SecurityException(string message, System.Exception inner) { }
        public override string ToString() { return default(string); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5500), AllowMultiple=false, Inherited=false)]
    public sealed partial class SecuritySafeCriticalAttribute : System.Attribute
    {
        public SecuritySafeCriticalAttribute() { }
    }
    [System.Security.SecurityCriticalAttribute]
    public abstract partial class SecurityState
    {
        protected SecurityState() { }
        public abstract void EnsureState();
        [System.Security.SecurityCriticalAttribute]
        public bool IsStateAvailable() { return default(bool); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false, Inherited=false)]
    public sealed partial class SecurityTransparentAttribute : System.Attribute
    {
        public SecurityTransparentAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UnverifiableCodeAttribute : System.Attribute
    {
        public UnverifiableCodeAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class VerificationException : System.SystemException
    {
        public VerificationException() { }
        public VerificationException(string message) { }
        public VerificationException(string message, System.Exception innerException) { }
    }
}
namespace System.Security.Permissions
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.ObsoleteAttribute("CodeAccessSecurityAttribute is no longer accessible to application code.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CodeAccessSecurityAttribute : System.Security.Permissions.SecurityAttribute
    {
        protected CodeAccessSecurityAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    }
    [System.ObsoleteAttribute("SecurityAction is no longer accessible to application code.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SecurityAction
    {
        Assert = 3,
        Demand = 2,
        [System.ObsoleteAttribute("Deny is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        Deny = 4,
        InheritanceDemand = 7,
        LinkDemand = 6,
        PermitOnly = 5,
        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        RequestMinimum = 8,
        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        RequestOptional = 9,
        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        RequestRefuse = 10,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.ObsoleteAttribute("SecurityAttribute is no longer accessible to application code.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class SecurityAttribute : System.Attribute
    {
        protected SecurityAttribute(System.Security.Permissions.SecurityAction action) { }
        public System.Security.Permissions.SecurityAction Action { get { return default(System.Security.Permissions.SecurityAction); } set { } }
        public bool Unrestricted { get { return default(bool); } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.ObsoleteAttribute("SecurityPermissionAttribute is no longer accessible to application code.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SecurityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public SecurityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool ControlAppDomain { get { return default(bool); } set { } }
        public bool ControlDomainPolicy { get { return default(bool); } set { } }
        public bool ControlEvidence { get { return default(bool); } set { } }
        public bool ControlPolicy { get { return default(bool); } set { } }
        public bool ControlThread { get { return default(bool); } set { } }
        public System.Security.Permissions.SecurityPermissionFlag Flags { get { return default(System.Security.Permissions.SecurityPermissionFlag); } set { } }
        public bool SkipVerification { get { return default(bool); } set { } }
        public bool UnmanagedCode { get { return default(bool); } set { } }
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("SecurityPermissionFlag is no longer accessible to application code.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SecurityPermissionFlag
    {
        AllFlags = 16383,
        Assertion = 1,
        BindingRedirects = 8192,
        ControlAppDomain = 1024,
        ControlDomainPolicy = 256,
        ControlEvidence = 32,
        ControlPolicy = 64,
        ControlPrincipal = 512,
        ControlThread = 16,
        Execution = 8,
        Infrastructure = 4096,
        NoFlags = 0,
        RemotingConfiguration = 2048,
        SerializationFormatter = 128,
        SkipVerification = 4,
        UnmanagedCode = 2,
    }
}
namespace System.Security.Principal
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IIdentity
    {
        string AuthenticationType { get; }
        bool IsAuthenticated { get; }
        string Name { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IPrincipal
    {
        System.Security.Principal.IIdentity Identity { get; }
        bool IsInRole(string role);
    }
    public enum TokenImpersonationLevel
    {
        Anonymous = 1,
        Delegation = 4,
        Identification = 2,
        Impersonation = 3,
        None = 0,
    }
}
namespace System.Text
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ASCIIEncoding : System.Text.Encoding
    {
        public ASCIIEncoding() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool IsSingleByte { get { return default(bool); } }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetByteCount(char* chars, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(char[] chars, int index, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(string chars) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetCharCount(byte* bytes, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetCharCount(byte[] bytes, int index, int count) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
        public override int GetMaxByteCount(int charCount) { return default(int); }
        public override int GetMaxCharCount(int byteCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string GetString(byte[] bytes, int byteIndex, int byteCount) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Decoder
    {
        protected Decoder() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.DecoderFallback Fallback { get { return default(System.Text.DecoderFallback); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.DecoderFallbackBuffer FallbackBuffer { get { return default(System.Text.DecoderFallbackBuffer); } }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { bytesUsed = default(int); charsUsed = default(int); completed = default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { bytesUsed = default(int); charsUsed = default(int); completed = default(bool); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush) { return default(int); }
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { return default(int); }
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual void Reset() { }
    }
    public sealed partial class DecoderExceptionFallback : System.Text.DecoderFallback
    {
        public DecoderExceptionFallback() { }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.DecoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.DecoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    public abstract partial class DecoderFallback
    {
        protected DecoderFallback() { }
        public static System.Text.DecoderFallback ExceptionFallback { get { return default(System.Text.DecoderFallback); } }
        public abstract int MaxCharCount { get; }
        public static System.Text.DecoderFallback ReplacementFallback { get { return default(System.Text.DecoderFallback); } }
        public abstract System.Text.DecoderFallbackBuffer CreateFallbackBuffer();
    }
    public abstract partial class DecoderFallbackBuffer
    {
        protected DecoderFallbackBuffer() { }
        public abstract int Remaining { get; }
        public abstract bool Fallback(byte[] bytesUnknown, int index);
        public abstract char GetNextChar();
        public abstract bool MovePrevious();
        public virtual void Reset() { }
    }
    public sealed partial class DecoderFallbackException : System.ArgumentException
    {
        public DecoderFallbackException() { }
        public DecoderFallbackException(string message) { }
        public DecoderFallbackException(string message, byte[] bytesUnknown, int index) { }
        public DecoderFallbackException(string message, System.Exception innerException) { }
        public byte[] BytesUnknown { get { return default(byte[]); } }
        public int Index { get { return default(int); } }
    }
    public sealed partial class DecoderReplacementFallback : System.Text.DecoderFallback
    {
        public DecoderReplacementFallback() { }
        public DecoderReplacementFallback(string replacement) { }
        public string DefaultString { get { return default(string); } }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.DecoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.DecoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Encoder
    {
        protected Encoder() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.EncoderFallback Fallback { get { return default(System.Text.EncoderFallback); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.EncoderFallbackBuffer FallbackBuffer { get { return default(System.Text.EncoderFallbackBuffer); } }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { charsUsed = default(int); bytesUsed = default(int); completed = default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { charsUsed = default(int); bytesUsed = default(int); completed = default(bool); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetByteCount(char* chars, int count, bool flush) { return default(int); }
        public abstract int GetByteCount(char[] chars, int index, int count, bool flush);
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { return default(int); }
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual void Reset() { }
    }
    public sealed partial class EncoderExceptionFallback : System.Text.EncoderFallback
    {
        public EncoderExceptionFallback() { }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.EncoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.EncoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    public abstract partial class EncoderFallback
    {
        protected EncoderFallback() { }
        public static System.Text.EncoderFallback ExceptionFallback { get { return default(System.Text.EncoderFallback); } }
        public abstract int MaxCharCount { get; }
        public static System.Text.EncoderFallback ReplacementFallback { get { return default(System.Text.EncoderFallback); } }
        public abstract System.Text.EncoderFallbackBuffer CreateFallbackBuffer();
    }
    public abstract partial class EncoderFallbackBuffer
    {
        protected EncoderFallbackBuffer() { }
        public abstract int Remaining { get; }
        public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
        public abstract bool Fallback(char charUnknown, int index);
        public abstract char GetNextChar();
        public abstract bool MovePrevious();
        public virtual void Reset() { }
    }
    public sealed partial class EncoderFallbackException : System.ArgumentException
    {
        public EncoderFallbackException() { }
        public EncoderFallbackException(string message) { }
        public EncoderFallbackException(string message, System.Exception innerException) { }
        public char CharUnknown { get { return default(char); } }
        public char CharUnknownHigh { get { return default(char); } }
        public char CharUnknownLow { get { return default(char); } }
        public int Index { get { return default(int); } }
        public bool IsUnknownSurrogate() { return default(bool); }
    }
    public sealed partial class EncoderReplacementFallback : System.Text.EncoderFallback
    {
        public EncoderReplacementFallback() { }
        public EncoderReplacementFallback(string replacement) { }
        public string DefaultString { get { return default(string); } }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.EncoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.EncoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Encoding
    {
        protected Encoding() { }
        protected Encoding(int codePage) { }
        protected Encoding(int codePage, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { }
        public static System.Text.Encoding ASCII { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding BigEndianUnicode { get { return default(System.Text.Encoding); } }
        public virtual int CodePage { get { return default(int); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.DecoderFallback DecoderFallback { get { return default(System.Text.DecoderFallback); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.EncoderFallback EncoderFallback { get { return default(System.Text.EncoderFallback); } set { } }
        public virtual string EncodingName { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual bool IsSingleByte { get { return default(bool); } }
        public static System.Text.Encoding Unicode { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding UTF32 { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding UTF7 { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding UTF8 { get { return default(System.Text.Encoding); } }
        public virtual string WebName { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual object Clone() { return default(object); }
        public static byte[] Convert(System.Text.Encoding srcEncoding, System.Text.Encoding dstEncoding, byte[] bytes) { return default(byte[]); }
        public static byte[] Convert(System.Text.Encoding srcEncoding, System.Text.Encoding dstEncoding, byte[] bytes, int index, int count) { return default(byte[]); }
        public override bool Equals(object value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetByteCount(char* chars, int count) { return default(int); }
        public virtual int GetByteCount(char[] chars) { return default(int); }
        public abstract int GetByteCount(char[] chars, int index, int count);
        public virtual int GetByteCount(string s) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
        public virtual byte[] GetBytes(char[] chars) { return default(byte[]); }
        public virtual byte[] GetBytes(char[] chars, int index, int count) { return default(byte[]); }
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
        public virtual byte[] GetBytes(string s) { return default(byte[]); }
        public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetCharCount(byte* bytes, int count) { return default(int); }
        public virtual int GetCharCount(byte[] bytes) { return default(int); }
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { return default(int); }
        public virtual char[] GetChars(byte[] bytes) { return default(char[]); }
        public virtual char[] GetChars(byte[] bytes, int index, int count) { return default(char[]); }
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        public virtual System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
        public virtual System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
        public static System.Text.Encoding GetEncoding(int codepage) { return default(System.Text.Encoding); }
        public static System.Text.Encoding GetEncoding(int codepage, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
        public static System.Text.Encoding GetEncoding(string name) { return default(System.Text.Encoding); }
        public static System.Text.Encoding GetEncoding(string name, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
        public override int GetHashCode() { return default(int); }
        public abstract int GetMaxByteCount(int charCount);
        public abstract int GetMaxCharCount(int byteCount);
        public virtual byte[] GetPreamble() { return default(byte[]); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe string GetString(byte* bytes, int byteCount) { return default(string); }
        public virtual string GetString(byte[] bytes) { return default(string); }
        public virtual string GetString(byte[] bytes, int index, int count) { return default(string); }
        public static void RegisterProvider(System.Text.EncodingProvider provider) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class EncodingProvider
    {
        public EncodingProvider() { }
        public abstract System.Text.Encoding GetEncoding(int codepage);
        public virtual System.Text.Encoding GetEncoding(int codepage, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
        public abstract System.Text.Encoding GetEncoding(string name);
        public virtual System.Text.Encoding GetEncoding(string name, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StringBuilder
    {
        public StringBuilder() { }
        public StringBuilder(int capacity) { }
        public StringBuilder(int capacity, int maxCapacity) { }
        public StringBuilder(string value) { }
        public StringBuilder(string value, int capacity) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public StringBuilder(string value, int startIndex, int length, int capacity) { }
        public int Capacity { get { return default(int); } set { } }
        [System.Runtime.CompilerServices.IndexerName("Chars")]
        public char this[int index] { get { return default(char); } set { } }
        public int Length { get { return default(int); } set { } }
        public int MaxCapacity { get { return default(int); } }
        public System.Text.StringBuilder Append(bool value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(byte value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(char value) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe System.Text.StringBuilder Append(char* value, int valueCount) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(char value, int repeatCount) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Append(char[] value) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Append(char[] value, int startIndex, int charCount) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(decimal value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(double value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(short value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(int value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(long value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(object value) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Append(sbyte value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Append(float value) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Append(string value) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Append(string value, int startIndex, int count) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Append(ushort value) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Append(uint value) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Append(ulong value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(System.IFormatProvider provider, string format, object arg0) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(System.IFormatProvider provider, string format, object arg0, object arg1) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(System.IFormatProvider provider, string format, object arg0, object arg1, object arg2) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(System.IFormatProvider provider, string format, params object[] args) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(string format, object arg0) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(string format, object arg0, object arg1) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder AppendFormat(string format, params object[] args) { return default(System.Text.StringBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.StringBuilder AppendLine() { return default(System.Text.StringBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Text.StringBuilder AppendLine(string value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Clear() { return default(System.Text.StringBuilder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }
        public int EnsureCapacity(int capacity) { return default(int); }
        public bool Equals(System.Text.StringBuilder sb) { return default(bool); }
        public System.Text.StringBuilder Insert(int index, bool value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, byte value) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Insert(int index, char value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, char[] value) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Insert(int index, char[] value, int startIndex, int charCount) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, decimal value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, double value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, short value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, int value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, long value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, object value) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Insert(int index, sbyte value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Insert(int index, float value) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Insert(int index, string value) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public System.Text.StringBuilder Insert(int index, string value, int count) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Insert(int index, ushort value) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Insert(int index, uint value) { return default(System.Text.StringBuilder); }
        [System.CLSCompliantAttribute(false)]
        public System.Text.StringBuilder Insert(int index, ulong value) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Remove(int startIndex, int length) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Replace(char oldChar, char newChar) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Replace(char oldChar, char newChar, int startIndex, int count) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Replace(string oldValue, string newValue) { return default(System.Text.StringBuilder); }
        public System.Text.StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { return default(System.Text.StringBuilder); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string ToString() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public string ToString(int startIndex, int length) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class UnicodeEncoding : System.Text.Encoding
    {
        public UnicodeEncoding() { }
        public UnicodeEncoding(bool bigEndian, bool byteOrderMark) { }
        public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }
        public override bool Equals(object value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetByteCount(char* chars, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(char[] chars, int index, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(string s) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetCharCount(byte* bytes, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetCharCount(byte[] bytes, int index, int count) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { return default(int); }
        public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
        public override int GetHashCode() { return default(int); }
        public override int GetMaxByteCount(int charCount) { return default(int); }
        public override int GetMaxCharCount(int byteCount) { return default(int); }
        public override byte[] GetPreamble() { return default(byte[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public override string GetString(byte[] bytes, int index, int count) { return default(string); }
    }
    public sealed partial class UTF32Encoding : System.Text.Encoding
    {
        public UTF32Encoding() { }
        public UTF32Encoding(bool bigEndian, bool byteOrderMark) { }
        public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }
        public override bool Equals(object value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetByteCount(char* chars, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(char[] chars, int index, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(string s) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetCharCount(byte* bytes, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetCharCount(byte[] bytes, int index, int count) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { return default(int); }
        public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
        public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
        public override int GetHashCode() { return default(int); }
        public override int GetMaxByteCount(int charCount) { return default(int); }
        public override int GetMaxCharCount(int byteCount) { return default(int); }
        public override byte[] GetPreamble() { return default(byte[]); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override string GetString(byte[] bytes, int index, int count) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class UTF7Encoding : System.Text.Encoding
    {
        public UTF7Encoding() { }
        public UTF7Encoding(bool allowOptionals) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetByteCount(char* chars, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(char[] chars, int index, int count) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(string s) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetCharCount(byte* bytes, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetCharCount(byte[] bytes, int index, int count) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { return default(int); }
        public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
        public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public override int GetMaxByteCount(int charCount) { return default(int); }
        public override int GetMaxCharCount(int byteCount) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public override string GetString(byte[] bytes, int index, int count) { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class UTF8Encoding : System.Text.Encoding
    {
        public UTF8Encoding() { }
        public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) { }
        public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }
        public override bool Equals(object value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetByteCount(char* chars, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(char[] chars, int index, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetByteCount(string chars) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetCharCount(byte* bytes, int count) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetCharCount(byte[] bytes, int index, int count) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { return default(int); }
        public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
        public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
        public override int GetHashCode() { return default(int); }
        public override int GetMaxByteCount(int charCount) { return default(int); }
        public override int GetMaxCharCount(int byteCount) { return default(int); }
        public override byte[] GetPreamble() { return default(byte[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public override string GetString(byte[] bytes, int index, int count) { return default(string); }
    }
}
namespace System.Threading
{
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class AbandonedMutexException : System.SystemException
    {
        public AbandonedMutexException() { }
        public AbandonedMutexException(int location, System.Threading.WaitHandle handle) { }
        public AbandonedMutexException(string message) { }
        public AbandonedMutexException(string message, System.Exception inner) { }
        public AbandonedMutexException(string message, System.Exception inner, int location, System.Threading.WaitHandle handle) { }
        public AbandonedMutexException(string message, int location, System.Threading.WaitHandle handle) { }
        public System.Threading.Mutex Mutex { get { return default(System.Threading.Mutex); } }
        public int MutexIndex { get { return default(int); } }
    }
    public sealed partial class AsyncLocal<T>
    {
        public AsyncLocal() { }
        [System.Security.SecurityCriticalAttribute]
        public AsyncLocal(System.Action<System.Threading.AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
        public T Value { [System.Security.SecuritySafeCriticalAttribute]get { return default(T); } [System.Security.SecuritySafeCriticalAttribute]set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AsyncLocalValueChangedArgs<T>
    {
        public T CurrentValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
        public T PreviousValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
        public bool ThreadContextChanged { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class AutoResetEvent : System.Threading.EventWaitHandle
    {
        public AutoResetEvent(bool initialState) : base (default(bool), default(System.Threading.EventResetMode)) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("IsCancellationRequested = {IsCancellationRequested}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CancellationToken
    {
        public CancellationToken(bool canceled) { throw new System.NotImplementedException(); }
        public bool CanBeCanceled { get { return default(bool); } }
        public bool IsCancellationRequested { get { return default(bool); } }
        public static System.Threading.CancellationToken None { get { return default(System.Threading.CancellationToken); } }
        public System.Threading.WaitHandle WaitHandle { get { return default(System.Threading.WaitHandle); } }
        public override bool Equals(object other) { return default(bool); }
        public bool Equals(System.Threading.CancellationToken other) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Threading.CancellationToken left, System.Threading.CancellationToken right) { return default(bool); }
        public static bool operator !=(System.Threading.CancellationToken left, System.Threading.CancellationToken right) { return default(bool); }
        public System.Threading.CancellationTokenRegistration Register(System.Action callback) { return default(System.Threading.CancellationTokenRegistration); }
        public System.Threading.CancellationTokenRegistration Register(System.Action callback, bool useSynchronizationContext) { return default(System.Threading.CancellationTokenRegistration); }
        public System.Threading.CancellationTokenRegistration Register(System.Action<object> callback, object state) { return default(System.Threading.CancellationTokenRegistration); }
        public System.Threading.CancellationTokenRegistration Register(System.Action<object> callback, object state, bool useSynchronizationContext) { return default(System.Threading.CancellationTokenRegistration); }
        public void ThrowIfCancellationRequested() { }
    }
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CancellationTokenRegistration : System.IDisposable, System.IEquatable<System.Threading.CancellationTokenRegistration>
    {
        public void Dispose() { }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Threading.CancellationTokenRegistration other) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Threading.CancellationTokenRegistration left, System.Threading.CancellationTokenRegistration right) { return default(bool); }
        public static bool operator !=(System.Threading.CancellationTokenRegistration left, System.Threading.CancellationTokenRegistration right) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    
    public partial class CancellationTokenSource : System.IDisposable
    {
        public CancellationTokenSource() { }
        public CancellationTokenSource(int millisecondsDelay) { }
        public CancellationTokenSource(System.TimeSpan delay) { }
        public bool IsCancellationRequested { get { return default(bool); } }
        public System.Threading.CancellationToken Token { get { return default(System.Threading.CancellationToken); } }
        public void Cancel() { }
        public void Cancel(bool throwOnFirstException) { }
        public void CancelAfter(int millisecondsDelay) { }
        public void CancelAfter(System.TimeSpan delay) { }
        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken token1, System.Threading.CancellationToken token2) { return default(System.Threading.CancellationTokenSource); }
        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(params System.Threading.CancellationToken[] tokens) { return default(System.Threading.CancellationTokenSource); }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public delegate void ContextCallback(object state);
    [System.Diagnostics.DebuggerDisplayAttribute("Initial Count={InitialCount}, Current Count={CurrentCount}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    
    public partial class CountdownEvent : System.IDisposable
    {
        public CountdownEvent(int initialCount) { }
        public int CurrentCount { get { return default(int); } }
        public int InitialCount { get { return default(int); } }
        public bool IsSet { get { return default(bool); } }
        public System.Threading.WaitHandle WaitHandle { get { return default(System.Threading.WaitHandle); } }
        public void AddCount() { }
        public void AddCount(int signalCount) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Reset() { }
        public void Reset(int count) { }
        public bool Signal() { return default(bool); }
        public bool Signal(int signalCount) { return default(bool); }
        public bool TryAddCount() { return default(bool); }
        public bool TryAddCount(int signalCount) { return default(bool); }
        public void Wait() { }
        public bool Wait(int millisecondsTimeout) { return default(bool); }
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        public bool Wait(System.TimeSpan timeout) { return default(bool); }
        public bool Wait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public enum EventResetMode
    {
        AutoReset = 0,
        ManualReset = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public partial class EventWaitHandle : System.Threading.WaitHandle
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode) { }
        [System.Security.SecurityCriticalAttribute]
        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name) { }
        [System.Security.SecurityCriticalAttribute]
        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name, out bool createdNew) { createdNew = default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Threading.EventWaitHandle OpenExisting(string name) { return default(System.Threading.EventWaitHandle); }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Reset() { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Set() { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public static bool TryOpenExisting(string name, out System.Threading.EventWaitHandle result) { result = default(System.Threading.EventWaitHandle); return default(bool); }
    }
    public sealed partial class ExecutionContext : System.IDisposable
    {
        internal ExecutionContext() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Threading.ExecutionContext Capture() { return default(System.Threading.ExecutionContext); }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        [System.Security.SecurityCriticalAttribute]
        public static void Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, object state) { }
    }
    public static partial class Interlocked
    {
        
        public static int Add(ref int location1, int value) { return default(int); }
        
        public static long Add(ref long location1, long value) { return default(long); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double CompareExchange(ref double location1, double value, double comparand) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static int CompareExchange(ref int location1, int value, int comparand) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static long CompareExchange(ref long location1, long value, long comparand) { return default(long); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.IntPtr CompareExchange(ref System.IntPtr location1, System.IntPtr value, System.IntPtr comparand) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static object CompareExchange(ref object location1, object value, object comparand) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static float CompareExchange(ref float location1, float value, float comparand) { return default(float); }
        
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class { return default(T); }
        
        public static int Decrement(ref int location) { return default(int); }
        public static long Decrement(ref long location) { return default(long); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static double Exchange(ref double location1, double value) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static int Exchange(ref int location1, int value) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static long Exchange(ref long location1, long value) { return default(long); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.IntPtr Exchange(ref System.IntPtr location1, System.IntPtr value) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static object Exchange(ref object location1, object value) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static float Exchange(ref float location1, float value) { return default(float); }
        
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static T Exchange<T>(ref T location1, T value) where T : class { return default(T); }
        
        public static int Increment(ref int location) { return default(int); }
        
        public static long Increment(ref long location) { return default(long); }
        public static void MemoryBarrier() { }
        public static long Read(ref long location) { return default(long); }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, System.Threading.NativeOverlapped* pOVERLAP);
    
    public static partial class LazyInitializer
    {
        public static T EnsureInitialized<T>(ref T target) where T : class { return default(T); }
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock) { return default(T); }
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, System.Func<T> valueFactory) { return default(T); }
        public static T EnsureInitialized<T>(ref T target, System.Func<T> valueFactory) where T : class { return default(T); }
    }
    public enum LazyThreadSafetyMode
    {
        ExecutionAndPublication = 2,
        None = 0,
        PublicationOnly = 1,
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
    
    public partial class LockRecursionException : System.Exception
    {
        public LockRecursionException() { }
        public LockRecursionException(string message) { }
        public LockRecursionException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class ManualResetEvent : System.Threading.EventWaitHandle
    {
        public ManualResetEvent(bool initialState) : base (default(bool), default(System.Threading.EventResetMode)) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Set = {IsSet}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    
    public partial class ManualResetEventSlim : System.IDisposable
    {
        public ManualResetEventSlim() { }
        public ManualResetEventSlim(bool initialState) { }
        public ManualResetEventSlim(bool initialState, int spinCount) { }
        public bool IsSet { get { return default(bool); } }
        public int SpinCount { get { return default(int); } }
        public System.Threading.WaitHandle WaitHandle { get { return default(System.Threading.WaitHandle); } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Reset() { }
        public void Set() { }
        public void Wait() { }
        public bool Wait(int millisecondsTimeout) { return default(bool); }
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        public bool Wait(System.TimeSpan timeout) { return default(bool); }
        public bool Wait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public static partial class Monitor
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static void Enter(object obj) { }
        public static void Enter(object obj, ref bool lockTaken) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Exit(object obj) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsEntered(object obj) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Pulse(object obj) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void PulseAll(object obj) { }
        public static bool TryEnter(object obj) { return default(bool); }
        public static void TryEnter(object obj, ref bool lockTaken) { }
        public static bool TryEnter(object obj, int millisecondsTimeout) { return default(bool); }
        public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken) { }
        public static bool TryEnter(object obj, System.TimeSpan timeout) { return default(bool); }
        public static void TryEnter(object obj, System.TimeSpan timeout, ref bool lockTaken) { }
        public static bool Wait(object obj) { return default(bool); }
        public static bool Wait(object obj, int millisecondsTimeout) { return default(bool); }
        public static bool Wait(object obj, System.TimeSpan timeout) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class Mutex : System.Threading.WaitHandle
    {
        
        [System.Security.SecuritySafeCriticalAttribute]
        public Mutex() { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public Mutex(bool initiallyOwned) { }
        
        [System.Security.SecurityCriticalAttribute]
        public Mutex(bool initiallyOwned, string name) { }
        
        [System.Security.SecurityCriticalAttribute]
        public Mutex(bool initiallyOwned, string name, out bool createdNew) { createdNew = default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Threading.Mutex OpenExisting(string name) { return default(System.Threading.Mutex); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public void ReleaseMutex() { }
        [System.Security.SecurityCriticalAttribute]
        public static bool TryOpenExisting(string name, out System.Threading.Mutex result) { result = default(System.Threading.Mutex); return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct NativeOverlapped
    {
        public System.IntPtr EventHandle;
        public System.IntPtr InternalHigh;
        public System.IntPtr InternalLow;
        public int OffsetHigh;
        public int OffsetLow;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Overlapped
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public Overlapped() { }
        public System.IAsyncResult AsyncResult { get { return default(System.IAsyncResult); } set { } }
        public int OffsetHigh { get { return default(int); } set { } }
        public int OffsetLow { get { return default(int); } set { } }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe static void Free(System.Threading.NativeOverlapped* nativeOverlappedPtr) { }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe System.Threading.NativeOverlapped* Pack(System.Threading.IOCompletionCallback iocb, object userData) { return default(System.Threading.NativeOverlapped*); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe static System.Threading.Overlapped Unpack(System.Threading.NativeOverlapped* nativeOverlappedPtr) { return default(System.Threading.Overlapped); }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe System.Threading.NativeOverlapped* UnsafePack(System.Threading.IOCompletionCallback iocb, object userData) { return default(System.Threading.NativeOverlapped*); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterizedThreadStart(object obj);
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class RegisteredWaitHandle
    {
        internal RegisteredWaitHandle() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Unregister(System.Threading.WaitHandle waitObject) { return default(bool); }
    }
    public sealed partial class Semaphore : System.Threading.WaitHandle
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public Semaphore(int initialCount, int maximumCount) { }
        [System.Security.SecurityCriticalAttribute]
        public Semaphore(int initialCount, int maximumCount, string name) { }
        [System.Security.SecurityCriticalAttribute]
        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew) { createdNew = default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Threading.Semaphore OpenExisting(string name) { return default(System.Threading.Semaphore); }
        public int Release() { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public int Release(int releaseCount) { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static bool TryOpenExisting(string name, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); return default(bool); }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class SemaphoreFullException : System.SystemException
    {
        public SemaphoreFullException() { }
        public SemaphoreFullException(string message) { }
        public SemaphoreFullException(string message, System.Exception innerException) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Current Count = {m_currentCount}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    
    public partial class SemaphoreSlim : System.IDisposable
    {
        public SemaphoreSlim(int initialCount) { }
        public SemaphoreSlim(int initialCount, int maxCount) { }
        public System.Threading.WaitHandle AvailableWaitHandle { get { return default(System.Threading.WaitHandle); } }
        public int CurrentCount { get { return default(int); } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public int Release() { return default(int); }
        public int Release(int releaseCount) { return default(int); }
        public void Wait() { }
        public bool Wait(int millisecondsTimeout) { return default(bool); }
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        public bool Wait(System.TimeSpan timeout) { return default(bool); }
        public bool Wait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
        public System.Threading.Tasks.Task WaitAsync() { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task<bool> WaitAsync(int millisecondsTimeout) { return default(System.Threading.Tasks.Task<bool>); }
        public System.Threading.Tasks.Task<bool> WaitAsync(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
        public System.Threading.Tasks.Task WaitAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task<bool> WaitAsync(System.TimeSpan timeout) { return default(System.Threading.Tasks.Task<bool>); }
        public System.Threading.Tasks.Task<bool> WaitAsync(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
    }
    public delegate void SendOrPostCallback(object state);
    [System.Diagnostics.DebuggerDisplayAttribute("IsHeld = {IsHeld}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]   
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SpinLock
    {
        public SpinLock(bool enableThreadOwnerTracking) { throw new System.NotImplementedException(); }
        public bool IsHeld { get { return default(bool); } }
        public bool IsHeldByCurrentThread { get { return default(bool); } }
        public bool IsThreadOwnerTrackingEnabled { get { return default(bool); } }
        public void Enter(ref bool lockTaken) { }
        
        public void Exit() { }
        
        public void Exit(bool useMemoryBarrier) { }
        public void TryEnter(ref bool lockTaken) { }
        public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }
        public void TryEnter(System.TimeSpan timeout, ref bool lockTaken) { }
    }
    
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SpinWait
    {
        public int Count { get { return default(int); } }
        public bool NextSpinWillYield { get { return default(bool); } }
        public void Reset() { }
        public void SpinOnce() { }
        public static void SpinUntil(System.Func<bool> condition) { }
        public static bool SpinUntil(System.Func<bool> condition, int millisecondsTimeout) { return default(bool); }
        public static bool SpinUntil(System.Func<bool> condition, System.TimeSpan timeout) { return default(bool); }
    }
    public partial class SynchronizationContext
    {
        public SynchronizationContext() { }
        public static System.Threading.SynchronizationContext Current { get { return default(System.Threading.SynchronizationContext); } }
        public virtual System.Threading.SynchronizationContext CreateCopy() { return default(System.Threading.SynchronizationContext); }
        public virtual void OperationCompleted() { }
        public virtual void OperationStarted() { }
        public virtual void Post(System.Threading.SendOrPostCallback d, object state) { }
        public virtual void Send(System.Threading.SendOrPostCallback d, object state) { }
        [System.Security.SecurityCriticalAttribute]
        public static void SetSynchronizationContext(System.Threading.SynchronizationContext syncContext) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SynchronizationLockException : System.SystemException
    {
        public SynchronizationLockException() { }
        public SynchronizationLockException(string message) { }
        public SynchronizationLockException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Thread : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public Thread(System.Threading.ParameterizedThreadStart start) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public Thread(System.Threading.ThreadStart start) { }
        public System.Globalization.CultureInfo CurrentCulture { get { return default(System.Globalization.CultureInfo); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public static System.Threading.Thread CurrentThread { get { return default(System.Threading.Thread); } }
        public System.Globalization.CultureInfo CurrentUICulture { get { return default(System.Globalization.CultureInfo); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public bool IsAlive { [System.Security.SecuritySafeCriticalAttribute][System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(bool); } }
        public bool IsBackground { [System.Security.SecuritySafeCriticalAttribute]get { return default(bool); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public int ManagedThreadId { [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]get { return default(int); } }
        public string Name { get { return default(string); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public System.Threading.ThreadState ThreadState { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Threading.ThreadState); } }
        ~Thread() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.AppDomain GetDomain() { return default(System.AppDomain); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        
        public void Join() { }
        [System.Security.SecuritySafeCriticalAttribute]
        
        public bool Join(int millisecondsTimeout) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)][System.Security.SecuritySafeCriticalAttribute]
        public static void MemoryBarrier() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Sleep(int millisecondsTimeout) { }
        public static void Sleep(System.TimeSpan timeout) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        
        public static void SpinWait(int iterations) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public void Start() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public void Start(object parameter) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ThreadAbortException : System.SystemException
    {
        internal ThreadAbortException() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
    public partial class ThreadLocal<T> : System.IDisposable
    {
        public ThreadLocal() { }
        public ThreadLocal(bool trackAllValues) { }
        public ThreadLocal(System.Func<T> valueFactory) { }
        public ThreadLocal(System.Func<T> valueFactory, bool trackAllValues) { }
        public bool IsValueCreated { get { return default(bool); } }
        [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
        public T Value { get { return default(T); } set { } }
        public System.Collections.Generic.IList<T> Values { get { return default(System.Collections.Generic.IList<T>); } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~ThreadLocal() { }
        public override string ToString() { return default(string); }
    }
    
    public static partial class ThreadPool
    {
        [System.Security.SecurityCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        public static bool BindHandle(System.Runtime.InteropServices.SafeHandle osHandle) { return default(bool); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void GetMaxThreads(out int workerThreads, out int completionPortThreads) { workerThreads = default(int); completionPortThreads = default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void GetMinThreads(out int workerThreads, out int completionPortThreads) { workerThreads = default(int); completionPortThreads = default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static bool QueueUserWorkItem(System.Threading.WaitCallback callBack) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static bool QueueUserWorkItem(System.Threading.WaitCallback callBack, object state) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlThread=true)]
        public static bool SetMaxThreads(int workerThreads, int completionPortThreads) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlThread=true)]
        public static bool SetMinThreads(int workerThreads, int completionPortThreads) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void ThreadStart();
    public sealed partial class ThreadStartException : System.SystemException
    {
        internal ThreadStartException() { }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ThreadState
    {
        Aborted = 256,
        AbortRequested = 128,
        Background = 4,
        Running = 0,
        Stopped = 16,
        StopRequested = 1,
        Suspended = 64,
        SuspendRequested = 2,
        Unstarted = 8,
        WaitSleepJoin = 32,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ThreadStateException : System.SystemException
    {
        public ThreadStateException() { }
        public ThreadStateException(string message) { }
        public ThreadStateException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class Timeout
    {
        public const int Infinite = -1;
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static readonly System.TimeSpan InfiniteTimeSpan;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    
    public sealed partial class Timer : System.IDisposable
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public Timer(System.Threading.TimerCallback callback) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public Timer(System.Threading.TimerCallback callback, object state, int dueTime, int period) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public Timer(System.Threading.TimerCallback callback, object state, long dueTime, long period) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public Timer(System.Threading.TimerCallback callback, object state, System.TimeSpan dueTime, System.TimeSpan period) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public Timer(System.Threading.TimerCallback callback, object state, uint dueTime, uint period) { }
        public bool Change(int dueTime, int period) { return default(bool); }
        public bool Change(long dueTime, long period) { return default(bool); }
        public bool Change(System.TimeSpan dueTime, System.TimeSpan period) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public bool Change(uint dueTime, uint period) { return default(bool); }
        public void Dispose() { }
        public bool Dispose(System.Threading.WaitHandle notifyObject) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void TimerCallback(object state);
    public static partial class Volatile
    {
        
        public static bool Read(ref bool location) { return default(bool); }
        
        public static byte Read(ref byte location) { return default(byte); }
        
        public static double Read(ref double location) { return default(double); }
        
        public static short Read(ref short location) { return default(short); }
        
        public static int Read(ref int location) { return default(int); }
        
        public static long Read(ref long location) { return default(long); }
        
        public static System.IntPtr Read(ref System.IntPtr location) { return default(System.IntPtr); }
        [System.CLSCompliantAttribute(false)]
        
        public static sbyte Read(ref sbyte location) { return default(sbyte); }
        
        public static float Read(ref float location) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        
        public static ushort Read(ref ushort location) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        
        public static uint Read(ref uint location) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static ulong Read(ref ulong location) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        
        public static System.UIntPtr Read(ref System.UIntPtr location) { return default(System.UIntPtr); }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static T Read<T>(ref T location) where T : class { return default(T); }
        
        public static void Write(ref bool location, bool value) { }
        
        public static void Write(ref byte location, byte value) { }
        
        public static void Write(ref double location, double value) { }
        
        public static void Write(ref short location, short value) { }
        
        public static void Write(ref int location, int value) { }
        
        public static void Write(ref long location, long value) { }
        
        public static void Write(ref System.IntPtr location, System.IntPtr value) { }
        [System.CLSCompliantAttribute(false)]
        
        public static void Write(ref sbyte location, sbyte value) { }
        
        public static void Write(ref float location, float value) { }
        [System.CLSCompliantAttribute(false)]
        
        public static void Write(ref ushort location, ushort value) { }
        [System.CLSCompliantAttribute(false)]
        
        public static void Write(ref uint location, uint value) { }
        [System.CLSCompliantAttribute(false)]
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Write(ref ulong location, ulong value) { }
        [System.CLSCompliantAttribute(false)]
        
        public static void Write(ref System.UIntPtr location, System.UIntPtr value) { }
        
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Write<T>(ref T location, T value) where T : class { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void WaitCallback(object state);
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class WaitHandle : System.IDisposable
    {
        protected static readonly System.IntPtr InvalidHandle;
        public const int WaitTimeout = 258;
        protected WaitHandle() { }
        public Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle { get { return default(Microsoft.Win32.SafeHandles.SafeWaitHandle); } set { } }
        public virtual void Close() { }
        public void Dispose() { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected virtual void Dispose(bool explicitDisposing) { }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles) { return default(bool); }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles, int millisecondsTimeout) { return default(bool); }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles, System.TimeSpan timeout) { return default(bool); }
        
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles) { return default(int); }
        
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles, int millisecondsTimeout) { return default(int); }
        
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles, System.TimeSpan timeout) { return default(int); }
        public virtual bool WaitOne() { return default(bool); }
        public virtual bool WaitOne(int millisecondsTimeout) { return default(bool); }
        public virtual bool WaitOne(System.TimeSpan timeout) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class WaitHandleCannotBeOpenedException : System.Exception
    {
        public WaitHandleCannotBeOpenedException() { }
        public WaitHandleCannotBeOpenedException(string message) { }
        public WaitHandleCannotBeOpenedException(string message, System.Exception innerException) { }
    }
    public static partial class WaitHandleExtensions
    {
        [System.Security.SecurityCriticalAttribute]
        public static Microsoft.Win32.SafeHandles.SafeWaitHandle GetSafeWaitHandle(this System.Threading.WaitHandle waitHandle) { return default(Microsoft.Win32.SafeHandles.SafeWaitHandle); }
        [System.Security.SecurityCriticalAttribute]
        public static void SetSafeWaitHandle(this System.Threading.WaitHandle waitHandle, Microsoft.Win32.SafeHandles.SafeWaitHandle value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void WaitOrTimerCallback(object state, bool timedOut);
}
namespace System.Threading.Tasks
{
    [System.Diagnostics.DebuggerDisplayAttribute("Concurrent={ConcurrentTaskCountForDebugger}, Exclusive={ExclusiveTaskCountForDebugger}, Mode={ModeForDebugger}")]   
    public partial class ConcurrentExclusiveSchedulerPair
    {
        public ConcurrentExclusiveSchedulerPair() { }
        public ConcurrentExclusiveSchedulerPair(System.Threading.Tasks.TaskScheduler taskScheduler) { }
        public ConcurrentExclusiveSchedulerPair(System.Threading.Tasks.TaskScheduler taskScheduler, int maxConcurrencyLevel) { }
        public ConcurrentExclusiveSchedulerPair(System.Threading.Tasks.TaskScheduler taskScheduler, int maxConcurrencyLevel, int maxItemsPerTask) { }
        public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
        public System.Threading.Tasks.TaskScheduler ConcurrentScheduler { get { return default(System.Threading.Tasks.TaskScheduler); } }
        public System.Threading.Tasks.TaskScheduler ExclusiveScheduler { get { return default(System.Threading.Tasks.TaskScheduler); } }
        public void Complete() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
   
    public partial class Task : System.IAsyncResult, System.IDisposable
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action action) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action action, System.Threading.CancellationToken cancellationToken) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action action, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action action, System.Threading.Tasks.TaskCreationOptions creationOptions) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action<object> action, object state) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action<object> action, object state, System.Threading.CancellationToken cancellationToken) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action<object> action, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Action<object> action, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { }
        public object AsyncState { get { return default(object); } }
        public static System.Threading.Tasks.Task CompletedTask { get { return default(System.Threading.Tasks.Task); } }
        public System.Threading.Tasks.TaskCreationOptions CreationOptions { get { return default(System.Threading.Tasks.TaskCreationOptions); } }
        public static System.Nullable<int> CurrentId { get { return default(System.Nullable<int>); } }
        public System.AggregateException Exception { get { return default(System.AggregateException); } }
        public static System.Threading.Tasks.TaskFactory Factory { get { return default(System.Threading.Tasks.TaskFactory); } }
        public int Id { get { return default(int); } }
        public bool IsCanceled { get { return default(bool); } }
        public bool IsCompleted { get { return default(bool); } }
        public bool IsFaulted { get { return default(bool); } }
        public System.Threading.Tasks.TaskStatus Status { get { return default(System.Threading.Tasks.TaskStatus); } }
        System.Threading.WaitHandle System.IAsyncResult.AsyncWaitHandle { get { return default(System.Threading.WaitHandle); } }
        bool System.IAsyncResult.CompletedSynchronously { get { return default(bool); } }
        public System.Runtime.CompilerServices.ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { return default(System.Runtime.CompilerServices.ConfiguredTaskAwaitable); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, object> continuationAction, object state) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, object> continuationAction, object state, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, object> continuationAction, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, object> continuationAction, object state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task, object> continuationAction, object state, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> continuationAction) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> continuationAction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task> continuationAction, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, object, TResult> continuationFunction, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, object, TResult> continuationFunction, object state, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, object, TResult> continuationFunction, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, object, TResult> continuationFunction, object state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWith<TResult>(System.Func<System.Threading.Tasks.Task, object, TResult> continuationFunction, object state, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        public static System.Threading.Tasks.Task Delay(int millisecondsDelay) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task Delay(int millisecondsDelay, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task Delay(System.TimeSpan delay) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task Delay(System.TimeSpan delay, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public static System.Threading.Tasks.Task FromCanceled(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task<TResult> FromCanceled<TResult>(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        public static System.Threading.Tasks.Task FromException(System.Exception exception) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task<TResult> FromException<TResult>(System.Exception exception) { return default(System.Threading.Tasks.Task<TResult>); }
        public static System.Threading.Tasks.Task<TResult> FromResult<TResult>(TResult result) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Runtime.CompilerServices.TaskAwaiter GetAwaiter() { return default(System.Runtime.CompilerServices.TaskAwaiter); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Threading.Tasks.Task Run(System.Action action) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Threading.Tasks.Task Run(System.Action action, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task Run(System.Func<System.Threading.Tasks.Task> function) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task Run(System.Func<System.Threading.Tasks.Task> function, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<TResult> function) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> function) { return default(System.Threading.Tasks.Task<TResult>); }
        public static System.Threading.Tasks.Task<TResult> Run<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> function, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        public void RunSynchronously() { }
        public void RunSynchronously(System.Threading.Tasks.TaskScheduler scheduler) { }
        public void Start() { }
        public void Start(System.Threading.Tasks.TaskScheduler scheduler) { }
        public void Wait() { }
        public bool Wait(int millisecondsTimeout) { return default(bool); }
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        public bool Wait(System.TimeSpan timeout) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static void WaitAll(params System.Threading.Tasks.Task[] tasks) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static bool WaitAll(System.Threading.Tasks.Task[] tasks, int millisecondsTimeout) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static bool WaitAll(System.Threading.Tasks.Task[] tasks, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static void WaitAll(System.Threading.Tasks.Task[] tasks, System.Threading.CancellationToken cancellationToken) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static bool WaitAll(System.Threading.Tasks.Task[] tasks, System.TimeSpan timeout) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static int WaitAny(params System.Threading.Tasks.Task[] tasks) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static int WaitAny(System.Threading.Tasks.Task[] tasks, int millisecondsTimeout) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static int WaitAny(System.Threading.Tasks.Task[] tasks, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static int WaitAny(System.Threading.Tasks.Task[] tasks, System.Threading.CancellationToken cancellationToken) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public static int WaitAny(System.Threading.Tasks.Task[] tasks, System.TimeSpan timeout) { return default(int); }
        public static System.Threading.Tasks.Task WhenAll(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> tasks) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task WhenAll(params System.Threading.Tasks.Task[] tasks) { return default(System.Threading.Tasks.Task); }
        public static System.Threading.Tasks.Task<TResult[]> WhenAll<TResult>(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<TResult>> tasks) { return default(System.Threading.Tasks.Task<TResult[]>); }
        public static System.Threading.Tasks.Task<TResult[]> WhenAll<TResult>(params System.Threading.Tasks.Task<TResult>[] tasks) { return default(System.Threading.Tasks.Task<TResult[]>); }
        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task> WhenAny(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> tasks) { return default(System.Threading.Tasks.Task<System.Threading.Tasks.Task>); }
        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task> WhenAny(params System.Threading.Tasks.Task[] tasks) { return default(System.Threading.Tasks.Task<System.Threading.Tasks.Task>); }
        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> WhenAny<TResult>(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<TResult>> tasks) { return default(System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>>); }
        public static System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> WhenAny<TResult>(params System.Threading.Tasks.Task<TResult>[] tasks) { return default(System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>>); }
        public static System.Runtime.CompilerServices.YieldAwaitable Yield() { return default(System.Runtime.CompilerServices.YieldAwaitable); }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
   
    public partial class Task<TResult> : System.Threading.Tasks.Task
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<TResult> function) : base (default(System.Action)) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken) : base (default(System.Action)) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions) : base (default(System.Action)) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<TResult> function, System.Threading.Tasks.TaskCreationOptions creationOptions) : base (default(System.Action)) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<object, TResult> function, object state) : base (default(System.Action)) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<object, TResult> function, object state, System.Threading.CancellationToken cancellationToken) : base (default(System.Action)) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<object, TResult> function, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions) : base (default(System.Action)) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public Task(System.Func<object, TResult> function, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) : base (default(System.Action)) { }
        public static new System.Threading.Tasks.TaskFactory<TResult> Factory { get { return default(System.Threading.Tasks.TaskFactory<TResult>); } }
        [System.Diagnostics.DebuggerBrowsableAttribute((System.Diagnostics.DebuggerBrowsableState)(0))]
        public TResult Result { get { return default(TResult); } }
        public new System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { return default(System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object> continuationAction, object state) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object> continuationAction, object state, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object> continuationAction, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object> continuationAction, object state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object> continuationAction, object state, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object, TNewResult> continuationFunction, object state) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object, TNewResult> continuationFunction, object state, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object, TNewResult> continuationFunction, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object, TNewResult> continuationFunction, object state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TNewResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TNewResult> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object, TNewResult> continuationFunction, object state, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TNewResult>); }
        public new System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter() { return default(System.Runtime.CompilerServices.TaskAwaiter<TResult>); }
    }
    public partial class TaskCanceledException : System.OperationCanceledException
    {
        public TaskCanceledException() { }
        public TaskCanceledException(string message) { }
        public TaskCanceledException(string message, System.Exception innerException) { }
        public TaskCanceledException(System.Threading.Tasks.Task task) { }
        public System.Threading.Tasks.Task Task { get { return default(System.Threading.Tasks.Task); } }
    }
    
    public partial class TaskCompletionSource<TResult>
    {
        public TaskCompletionSource() { }
        public TaskCompletionSource(object state) { }
        public TaskCompletionSource(object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { }
        public TaskCompletionSource(System.Threading.Tasks.TaskCreationOptions creationOptions) { }
        public System.Threading.Tasks.Task<TResult> Task { get { return default(System.Threading.Tasks.Task<TResult>); } }
        public void SetCanceled() { }
        public void SetException(System.Collections.Generic.IEnumerable<System.Exception> exceptions) { }
        public void SetException(System.Exception exception) { }
        public void SetResult(TResult result) { }
        public bool TrySetCanceled() { return default(bool); }
        public bool TrySetCanceled(System.Threading.CancellationToken cancellationToken) { return default(bool); }
        public bool TrySetException(System.Collections.Generic.IEnumerable<System.Exception> exceptions) { return default(bool); }
        public bool TrySetException(System.Exception exception) { return default(bool); }
        public bool TrySetResult(TResult result) { return default(bool); }
    }
    [System.FlagsAttribute]
    public enum TaskContinuationOptions
    {
        AttachedToParent = 4,
        DenyChildAttach = 8,
        ExecuteSynchronously = 524288,
        HideScheduler = 16,
        LazyCancellation = 32,
        LongRunning = 2,
        None = 0,
        NotOnCanceled = 262144,
        NotOnFaulted = 131072,
        NotOnRanToCompletion = 65536,
        OnlyOnCanceled = 196608,
        OnlyOnFaulted = 327680,
        OnlyOnRanToCompletion = 393216,
        PreferFairness = 1,
        RunContinuationsAsynchronously = 64,
    }
    [System.FlagsAttribute]
    public enum TaskCreationOptions
    {
        AttachedToParent = 4,
        DenyChildAttach = 8,
        HideScheduler = 16,
        LongRunning = 2,
        None = 0,
        PreferFairness = 1,
        RunContinuationsAsynchronously = 64,
    }
    
    public partial class TaskFactory
    {
        public TaskFactory() { }
        public TaskFactory(System.Threading.CancellationToken cancellationToken) { }
        public TaskFactory(System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { }
        public TaskFactory(System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { }
        public TaskFactory(System.Threading.Tasks.TaskScheduler scheduler) { }
        public System.Threading.CancellationToken CancellationToken { get { return default(System.Threading.CancellationToken); } }
        public System.Threading.Tasks.TaskContinuationOptions ContinuationOptions { get { return default(System.Threading.Tasks.TaskContinuationOptions); } }
        public System.Threading.Tasks.TaskCreationOptions CreationOptions { get { return default(System.Threading.Tasks.TaskCreationOptions); } }
        public System.Threading.Tasks.TaskScheduler Scheduler { get { return default(System.Threading.Tasks.TaskScheduler); } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task[]> continuationAction) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task[]> continuationAction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task[]> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task[]> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]> continuationAction) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]> continuationAction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>[]> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task> continuationAction) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task> continuationAction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Action<System.Threading.Tasks.Task> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TResult>(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>> continuationAction) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>> continuationAction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Action<System.Threading.Tasks.Task<TAntecedentResult>> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task FromAsync(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, object state) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task FromAsync(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task FromAsync(System.IAsyncResult asyncResult, System.Action<System.IAsyncResult> endMethod) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task FromAsync(System.IAsyncResult asyncResult, System.Action<System.IAsyncResult> endMethod, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task FromAsync(System.IAsyncResult asyncResult, System.Action<System.IAsyncResult> endMethod, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, object state) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.IAsyncResult asyncResult, System.Func<System.IAsyncResult, TResult> endMethod) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.IAsyncResult asyncResult, System.Func<System.IAsyncResult, TResult> endMethod, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> FromAsync<TResult>(System.IAsyncResult asyncResult, System.Func<System.IAsyncResult, TResult> endMethod, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TResult>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TResult>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Action<System.IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TResult>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TResult>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action action) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action action, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action action, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action action, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action<object> action, object state) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action<object> action, object state, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action<object> action, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task StartNew(System.Action<object> action, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult> function) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<TResult> function, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<object, TResult> function, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<object, TResult> function, object state, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<object, TResult> function, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew<TResult>(System.Func<object, TResult> function, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
    }
    
    public partial class TaskFactory<TResult>
    {
        public TaskFactory() { }
        public TaskFactory(System.Threading.CancellationToken cancellationToken) { }
        public TaskFactory(System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { }
        public TaskFactory(System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { }
        public TaskFactory(System.Threading.Tasks.TaskScheduler scheduler) { }
        public System.Threading.CancellationToken CancellationToken { get { return default(System.Threading.CancellationToken); } }
        public System.Threading.Tasks.TaskContinuationOptions ContinuationOptions { get { return default(System.Threading.Tasks.TaskContinuationOptions); } }
        public System.Threading.Tasks.TaskCreationOptions CreationOptions { get { return default(System.Threading.Tasks.TaskCreationOptions); } }
        public System.Threading.Tasks.TaskScheduler Scheduler { get { return default(System.Threading.Tasks.TaskScheduler); } }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task[], TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAll<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>[], TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny(System.Threading.Tasks.Task[] tasks, System.Func<System.Threading.Tasks.Task, TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> ContinueWhenAny<TAntecedentResult>(System.Threading.Tasks.Task<TAntecedentResult>[] tasks, System.Func<System.Threading.Tasks.Task<TAntecedentResult>, TResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync(System.Func<System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult asyncResult, System.Func<System.IAsyncResult, TResult> endMethod) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult asyncResult, System.Func<System.IAsyncResult, TResult> endMethod, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> FromAsync(System.IAsyncResult asyncResult, System.Func<System.IAsyncResult, TResult> endMethod, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1>(System.Func<TArg1, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2>(System.Func<TArg1, TArg2, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        public System.Threading.Tasks.Task<TResult> FromAsync<TArg1, TArg2, TArg3>(System.Func<TArg1, TArg2, TArg3, System.AsyncCallback, object, System.IAsyncResult> beginMethod, System.Func<System.IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> function) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<TResult> function, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<object, TResult> function, object state) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<object, TResult> function, object state, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<object, TResult> function, object state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions, System.Threading.Tasks.TaskScheduler scheduler) { return default(System.Threading.Tasks.Task<TResult>); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public System.Threading.Tasks.Task<TResult> StartNew(System.Func<object, TResult> function, object state, System.Threading.Tasks.TaskCreationOptions creationOptions) { return default(System.Threading.Tasks.Task<TResult>); }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Id={Id}")]   
    public abstract partial class TaskScheduler
    {
        protected TaskScheduler() { }
        public static System.Threading.Tasks.TaskScheduler Current { get { return default(System.Threading.Tasks.TaskScheduler); } }
        public static System.Threading.Tasks.TaskScheduler Default { get { return default(System.Threading.Tasks.TaskScheduler); } }
        public int Id { get { return default(int); } }
        public virtual int MaximumConcurrencyLevel { get { return default(int); } }
        public static event System.EventHandler<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> UnobservedTaskException { add { } remove { } }
        public static System.Threading.Tasks.TaskScheduler FromCurrentSynchronizationContext() { return default(System.Threading.Tasks.TaskScheduler); }
        [System.Security.SecurityCriticalAttribute]
        protected abstract System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task> GetScheduledTasks();
        [System.Security.SecurityCriticalAttribute]
        protected internal abstract void QueueTask(System.Threading.Tasks.Task task);
        [System.Security.SecurityCriticalAttribute]
        protected internal virtual bool TryDequeue(System.Threading.Tasks.Task task) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        protected bool TryExecuteTask(System.Threading.Tasks.Task task) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        protected abstract bool TryExecuteTaskInline(System.Threading.Tasks.Task task, bool taskWasPreviouslyQueued);
    }
    public partial class TaskSchedulerException : System.Exception
    {
        public TaskSchedulerException() { }
        public TaskSchedulerException(System.Exception innerException) { }
        public TaskSchedulerException(string message) { }
        public TaskSchedulerException(string message, System.Exception innerException) { }
    }
    public enum TaskStatus
    {
        Canceled = 6,
        Created = 0,
        Faulted = 7,
        RanToCompletion = 5,
        Running = 3,
        WaitingForActivation = 1,
        WaitingForChildrenToComplete = 4,
        WaitingToRun = 2,
    }
    public partial class UnobservedTaskExceptionEventArgs : System.EventArgs
    {
        public UnobservedTaskExceptionEventArgs(System.AggregateException exception) { }
        public System.AggregateException Exception { get { return default(System.AggregateException); } }
        public bool Observed { get { return default(bool); } }
        public void SetObserved() { }
    }
}
