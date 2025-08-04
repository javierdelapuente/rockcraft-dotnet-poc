# General information

[dotnet_v2_plugin](https://github.com/canonical/crafot-parts/blob/main/craft_parts/plugins/dotnet_v2_plugin.py)

[.NET Content Snaps](https://github.com/canonical/dotnet-content-snaps)

[.NET Snap](https://github.com/canonical/dotnet-snap)

Internal spec FO205

# Plugin

Only two rids defined, linux-amd64 and linux-arm64. I think
s390x and ppc64el cannot be self-contained, so it makes sense.

Snaps are not available for s390x and ppc64el. See https://github.com/canonical/dotnet-content-snaps/blob/97f05b792fb0fec0e4785faef00e80edd0f856c8/snaps/aspnetcore-runtime-80/snap/snapcraft.yaml#L18

The package dotnet8 exists for all architecture in Noble.

If the part `dotnet-deps` exists or the `dotnet-version` is defined, the plugin does not install the build_snap.

AFAIK, the plugin does not install the runtime. So if the app is not self-contained, it may not work.

What should be use as a runtime? I mean, for content snaps there is:
- dotnet-runtime-X
- aspnetcore-runtime-X


## Plugin options

Global Flags (default):

- dotnet-configuration: Release (Release)
- dotnet-project -> TODO What to do in here? (-)
- dotnet-properties: - (-)
- dotnet-self-contained -> TODO What to do in here? (False)
- dotnet-verbosity: normal (normal)
- dotnet-version: 8.0 (-)


Restore-specific Flags:

- dotnet-restore-sources: - (-)
- dotnet-restore-properties: - (-)
- dotnet-restore-configfile: - (-)


Build-specific Flags:

- dotnet-build-framework: - (-)
- dotnet-build-properties: - (-)


Publish-specific Flags:

- dotnet-publish-properties: - (-)
