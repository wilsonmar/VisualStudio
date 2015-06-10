This mark-down file describes the OAuth API sample script to create a listener service programmed in 
**C# ASP.NET Web Service API**.

This repo holds a sample script presented in
https://www.visualstudio.com/en-us/integrate/get-started/auth/oauth

OAuth involves **signing** which this sample library provides:  
https://github.com/buildmaster/oauth-mvc.net
by Owen Evans at http://www.bgeek.net and http://hoist.io/, an authentication service.

### <a name="AppAuthActions"> Auth Actions</a>
These are the actions the app performs on behalf of users
1. Request to authorize user  
2. User grants access to app 
3. Send authorization code for user.
4. Use authorization code to get token.
5. Use token to call API.


The script follows the widely adopted industry-standard 
http://oauth.net/2/
by going through these steps:

### <a name="Scopes"> Scopes</a>
API scopes define what an app and its users are permitted to do.
  * User profile (read)
  * Work items (read)	Work items (read and write)
  * Build (read)	Build (read and execute)
  * Code (read)	Code (read and write)	Code (read, write, and manage)
  * Team rooms (read and write)	Team rooms (read, write, and manage)
  * Test management (read)	
  * Test management (read and write)

The scopes for an app are defined on https://app.vssps.visualstudio.com/app/register

