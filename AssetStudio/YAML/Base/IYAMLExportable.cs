﻿namespace AssetStudio
{
    public interface IYAMLExportable
    {
        YAMLNode ExportYAML(int[] version);
    }
}
