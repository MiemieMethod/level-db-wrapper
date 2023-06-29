namespace LevelDBWrapper;

public class Options : LevelDBHandle
{
    public Options()
    {
        Handle = NativeMethods.leveldb_options_create();
        NativeMethods.leveldb_options_set_compression(this.Handle, 4);
    }
}

public class WriteOptions : LevelDBHandle
{
    public WriteOptions()
    {
        Handle = NativeMethods.leveldb_writeoptions_create();
    }
}

public class ReadOptions : LevelDBHandle
{
    public ReadOptions()
    {
        Handle = NativeMethods.leveldb_readoptions_create();
    }

    public Snapshot Snapshot
    {
        set { NativeMethods.leveldb_readoptions_set_snapshot(this.Handle, value.Handle); }
    }
}