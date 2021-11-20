// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
    [NativeTypeName("struct IWICColorContext : IUnknown")]
    [NativeInheritance("IUnknown")]
    internal unsafe partial struct IWICColorContext : IWICColorContext.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)(lpVtbl[0]))((IWICColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)(lpVtbl[1]))((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)(lpVtbl[2]))((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, ushort*, int>)(lpVtbl[3]))((IWICColorContext*)Unsafe.AsPointer(ref this), wzFilename);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, uint cbBufferSize)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)(lpVtbl[4]))((IWICColorContext*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT InitializeFromExifColorSpace(uint value)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, int>)(lpVtbl[5]))((IWICColorContext*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetType(WICColorContextType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, WICColorContextType*, int>)(lpVtbl[6]))((IWICColorContext*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)(lpVtbl[7]))((IWICColorContext*)Unsafe.AsPointer(ref this), cbBuffer, pbBuffer, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetExifColorSpace(uint* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint*, int>)(lpVtbl[8]))((IWICColorContext*)Unsafe.AsPointer(ref this), pValue);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename);

            [VtblIndex(4)]
            HRESULT InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, uint cbBufferSize);

            [VtblIndex(5)]
            HRESULT InitializeFromExifColorSpace(uint value);

            [VtblIndex(6)]
            HRESULT GetType(WICColorContextType* pType);

            [VtblIndex(7)]
            HRESULT GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual);

            [VtblIndex(8)]
            HRESULT GetExifColorSpace(uint* pValue);
        }

        internal partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, ushort*, int> InitializeFromFilename;

            [NativeTypeName("HRESULT (const BYTE *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int> InitializeFromMemory;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, uint, int> InitializeFromExifColorSpace;

            [NativeTypeName("HRESULT (WICColorContextType *) __attribute__((stdcall))")]
            public new delegate* unmanaged[Stdcall]<IWICColorContext*, WICColorContextType*, int> GetType;

            [NativeTypeName("HRESULT (UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int> GetProfileBytes;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<IWICColorContext*, uint*, int> GetExifColorSpace;
        }
    }
}