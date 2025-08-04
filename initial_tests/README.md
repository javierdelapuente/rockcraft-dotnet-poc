sudo snap install dotnet-sdk-80
sudo snap install dotnet-runtime-80

/snap/dotnet-sdk-80/current/usr/bin/dotnet
/snap/dotnet-sdk-80/43/usr/bin/dotnet build

??

https://github.com/canonical/dotnet-snap
https://github.com/canonical/dotnet-content-snaps




sudo rockcraft.skopeo --insecure-policy copy oci-archive:my-rock-name_0.1_amd64.rock docker-daemon:my-rock-name:latest

docker run --rm --name dotnet -p 5000:5000 my-rock-name:latest
docker exec -ti dotnet bash 


---

plugin Dotnetv2:

https://github.com/canonical/craft-parts/blob/main/craft_parts/plugins/dotnet_v2_plugin.py



---

What the plugin does:

only rid:
    "amd64": "linux-x64",
    "arm64": "linux-arm64",

Defaults to use.

Global Flags:

dotnet-configuration: Release
dotnet-project -> TODO What to do in here?
dotnet-properties: (empty)
dotnet-self-contained -> TODO What to do in here?
dotnet-verbosity: normal
dotnet-version: 8.0 (if not specified, you are supposed to provide it in the plugin)


Restore-specific Flags:

dotnet-restore-sources: -
dotnet-restore-properties: -
dotnet-restore-configfile: - 


Build-specific Flags:

dotnet-build-framework: -
dotnet-build-properties: -


Publish-specific Flags:

dotnet-publish-properties: -




--- 

Only for 24.04. Use 8.0 for all.

Use only dotnet-sdk snap (dotnet-sdk-80) as in the plugin.

If dotnet-deps in parts, do not install build dotnet-sdk.

