This is a Visual Studio 2017 project made using default template of web application. To run it ASP.NET should be installed.

UI TESTS: To run UI tests locally you need to open 2 instances of Visual Studio:
	1. Open VS 1: Click "ISS Express (Firefox)", the green play button, which would launch the server with the app.
	2. Open VS 2: Run UI Tests.
	App needs to be hosted on a server, and this way VS configures everything so selenium tests could be launched on local machine. A bit of a workaround here.
	VS does not allow to launch and run tests on a single instance at the same time.