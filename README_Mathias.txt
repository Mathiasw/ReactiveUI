So this is the attempt to create the REAL ReactiveUI at version 4.6.4 from the ORIGINAL repository.

It will only - as far as I can see - build under VS2012. So you'll need that for a start!

The file FicxTLSNugetIssue.reg was an attempt to fix the problems with Nuget on this system being SO OLD that it cannot get a TLS connecxtion tpo NuGet. It doesn't work in Wappiong and it;'s not going to work in LBG either.

The home directory I'm working on is at: C:\Users\Mathias\source\repos\Projects\Rider\ReactiveUI

Best stick to ReactiveUI_Net4Only


Building under VS2010
---------------------
No. You cannot open either ReactiveUI_Net4Only.sln or ReactiveUI.sln under VS2010.
So that was a waste of my time installing it, then.

Building under VS2012
---------------------

Everything to do with NuGet is not working well. Bad request, etc.

Open it in 2017 and ONLY restore the NuGet poackages? 

This gives you a NuGet.Config format errior : does not contain the expected root element configuration.
So I hid Nuget.Config and tried again and it nearly worked and I get the error with the locked MS build tasks again.


Building under PowewrShell
--------------------------