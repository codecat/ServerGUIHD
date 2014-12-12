Server GUI HD The Second Encounter
==================================

Serious Sam HD: The Second Encounter dedicated server runner.

This used to be hosted on servergui.codeplex.com.

## Install

1. Put the exe in `Steam\steamapps\common\serious sam hd the second encounter`.
2. Make sure `SamHD_TSE_DedicatedServer.exe` exists in the `Bin` directory. If not, download from Steam's "Tools" tab.
3. Run the exe.

Everything should work fine from this point. If it does not, make sure you have the latest .Net Framework 4.0 installed.

Contact: sam@angelog.nl or at Seriously! as Scratch.

## When using custom +exec script

When using a custom `+exec` script under the "Extras" tab and you're using interval chat messages, make sure you put this line somewhere in your custom script:

    dofile("Content/SeriousSamHD_TSE/SGUIHD.lua")

