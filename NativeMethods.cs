using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LevelDBWrapper
{
    internal static class NativeMethods
    {
        public static readonly Encoding Encoding = Encoding.UTF8;

        public static IntPtr leveldb_open(IntPtr options, byte[] path, out IntPtr error)
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_open(options, path, out error) : NativeMethods32.leveldb_open(options, path, out error);
        }
        public static IntPtr leveldb_options_create()
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_options_create() : NativeMethods32.leveldb_options_create();
        }
        public static IntPtr leveldb_writeoptions_create()
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_writeoptions_create() : NativeMethods32.leveldb_writeoptions_create();
        }
        public static IntPtr leveldb_writebatch_create()
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_writebatch_create() : NativeMethods32.leveldb_writebatch_create();
        }
        public static void leveldb_writebatch_put(IntPtr batch, byte[] key, int keylen, byte[] val, int vallen)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_writebatch_put(batch, key, keylen, val, vallen);
            else
                NativeMethods32.leveldb_writebatch_put(batch, key, keylen, val, vallen);
        }
        public static void leveldb_write(IntPtr db, IntPtr options, IntPtr batch, out IntPtr errptr)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_write(db, options, batch, out errptr);
            else
                NativeMethods32.leveldb_write(db, options, batch, out errptr);
        }
        public static void leveldb_delete(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr errptr)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_delete(db, options, key, keylen, out errptr);
            else
                NativeMethods32.leveldb_delete(db, options, key, keylen, out errptr);
        }
        public static IntPtr leveldb_get(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr)
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_get(db, options, key, keylen, out vallen, out errptr) : NativeMethods32.leveldb_get(db, options, key, keylen, out vallen, out errptr);
        }
        public static void leveldb_put(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen, out IntPtr errptr)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_put(db, options, key, keylen, val, vallen, out errptr);
            else
                NativeMethods32.leveldb_put(db, options, key, keylen, val, vallen, out errptr);
        }
        public static IntPtr leveldb_readoptions_create()
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_readoptions_create() : NativeMethods32.leveldb_readoptions_create();
        }
        public static void leveldb_free(IntPtr ptr)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_free(ptr);
            else
                NativeMethods32.leveldb_free(ptr);
        }
        public static IntPtr leveldb_create_snapshot(IntPtr db)
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_create_snapshot(db) : NativeMethods32.leveldb_create_snapshot(db);
        }
        public static IntPtr leveldb_create_iterator(IntPtr db, IntPtr options)
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_create_iterator(db, options) : NativeMethods32.leveldb_create_iterator(db, options);
        }
        public static void leveldb_readoptions_set_snapshot(IntPtr options, IntPtr snapshot)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_readoptions_set_snapshot(options, snapshot);
            else
                NativeMethods32.leveldb_readoptions_set_snapshot(options, snapshot);
        }
        public static void leveldb_release_snapshot(IntPtr db, IntPtr snapshot)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_release_snapshot(db, snapshot);
            else
                NativeMethods32.leveldb_release_snapshot(db, snapshot);
        }
        public static byte leveldb_iter_valid(IntPtr iterator)
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_iter_valid(iterator) : NativeMethods32.leveldb_iter_valid(iterator);
        }
        public static void leveldb_iter_seek_to_first(IntPtr iterator)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_iter_seek_to_first(iterator);
            else
                NativeMethods32.leveldb_iter_seek_to_first(iterator);
        }
        public static void leveldb_iter_seek_to_last(IntPtr iterator)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_iter_seek_to_last(iterator);
            else
                NativeMethods32.leveldb_iter_seek_to_last(iterator);
        }
        public static void leveldb_iter_seek(IntPtr iterator, byte[] key, int length)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_iter_seek(iterator, key, length);
            else
                NativeMethods32.leveldb_iter_seek(iterator, key, length);
        }
        public static void leveldb_iter_seek(IntPtr iterator, ref int key, int length)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_iter_seek(iterator, ref key, length);
            else
                NativeMethods32.leveldb_iter_seek(iterator, ref key, length);
        }
        public static void leveldb_iter_next(IntPtr iterator)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_iter_next(iterator);
            else
                NativeMethods32.leveldb_iter_next(iterator);
        }
        public static void leveldb_iter_prev(IntPtr iterator)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_iter_prev(iterator);
            else
                NativeMethods32.leveldb_iter_prev(iterator);
        }
        public static IntPtr leveldb_iter_key(IntPtr iterator, out int length)
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_iter_key(iterator, out length) : NativeMethods32.leveldb_iter_key(iterator, out length);
        }
        public static IntPtr leveldb_iter_value(IntPtr iterator, out int length)
        {
            return Environment.Is64BitProcess ? NativeMethods64.leveldb_iter_value(iterator, out length) : NativeMethods32.leveldb_iter_value(iterator, out length);
        }
        public static void leveldb_iter_destroy(IntPtr iterator)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_iter_destroy(iterator);
            else
                NativeMethods32.leveldb_iter_destroy(iterator);
        }
        public static void leveldb_options_set_compression(IntPtr options, int n)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_options_set_compression(options, n);
            else
                NativeMethods32.leveldb_options_set_compression(options, n);
        }
        public static void leveldb_close(IntPtr db)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_close(db);
            else
                NativeMethods32.leveldb_close(db);
        }
        public static void leveldb_writebatch_destroy(IntPtr batch)
        {
            if (Environment.Is64BitProcess)
                NativeMethods64.leveldb_writebatch_destroy(batch);
            else
                NativeMethods32.leveldb_writebatch_destroy(batch);
        }
    }

    internal static class NativeMethods64
    {
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_open(IntPtr options, byte[] path, out IntPtr error);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_options_create();
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_writeoptions_create();
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_writebatch_create();
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_writebatch_put(IntPtr batch, byte[] key, int keylen, byte[] val, int vallen);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_write(IntPtr db, IntPtr options, IntPtr batch, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_delete(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_get(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_put(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_readoptions_create();
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_free(IntPtr ptr);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_create_snapshot(IntPtr db);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_create_iterator(IntPtr db, IntPtr options);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_readoptions_set_snapshot(IntPtr options, IntPtr snapshot);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_release_snapshot(IntPtr db, IntPtr snapshot);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte leveldb_iter_valid(IntPtr iterator);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek_to_first(IntPtr iterator);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek_to_last(IntPtr iterator);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek(IntPtr iterator, byte[] key, int length);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek(IntPtr iterator, ref int key, int length);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_next(IntPtr iterator);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_prev(IntPtr iterator);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_iter_key(IntPtr iterator, out int length);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_iter_value(IntPtr iterator, out int length);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_destroy(IntPtr iterator);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_options_set_compression(IntPtr options, int n);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_close(IntPtr db);
        [DllImport("leveldb_mcpe_win_amd64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_writebatch_destroy(IntPtr batch);
    }

    internal static class NativeMethods32
    {
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_open(IntPtr options, byte[] path, out IntPtr error);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_options_create();
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_writeoptions_create();
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_writebatch_create();
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_writebatch_put(IntPtr batch, byte[] key, int keylen, byte[] val, int vallen);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_write(IntPtr db, IntPtr options, IntPtr batch, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_delete(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_get(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, out IntPtr vallen, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_put(IntPtr db, IntPtr options, byte[] key, IntPtr keylen, byte[] val, IntPtr vallen, out IntPtr errptr);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_readoptions_create();
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_free(IntPtr ptr);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_create_snapshot(IntPtr db);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_create_iterator(IntPtr db, IntPtr options);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_readoptions_set_snapshot(IntPtr options, IntPtr snapshot);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_release_snapshot(IntPtr db, IntPtr snapshot);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte leveldb_iter_valid(IntPtr iterator);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek_to_first(IntPtr iterator);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek_to_last(IntPtr iterator);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek(IntPtr iterator, byte[] key, int length);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_seek(IntPtr iterator, ref int key, int length);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_next(IntPtr iterator);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_prev(IntPtr iterator);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_iter_key(IntPtr iterator, out int length);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr leveldb_iter_value(IntPtr iterator, out int length);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_iter_destroy(IntPtr iterator);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_options_set_compression(IntPtr options, int n);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_close(IntPtr db);
        [DllImport("leveldb_mcpe_win32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void leveldb_writebatch_destroy(IntPtr batch);
    }
}
