var ROUTES_INDEX = {"name":"<root>","kind":"module","className":"AppModule","children":[{"name":"routes","filename":"src/app/app-routing.module.ts","module":"AppRoutingModule","children":[{"path":"","component":"HomeComponent"},{"path":"auth","loadChildren":"./auth/auth.module#AuthModule","canActivate":["LoginGuard"]},{"path":"login","loadChildren":"./auth/auth.module#AuthModule","canActivate":["LoginGuard"]},{"path":"registro","loadChildren":"./auth/auth.module#AuthModule","canActivate":["LoginGuard"]},{"path":"recuperacion","loadChildren":"./auth/auth.module#AuthModule","canActivate":["LoginGuard"]},{"path":"carrito","component":"CarritoComponent"},{"path":"tienda/producto/:id","component":"DetalleProductoComponent"},{"path":"tienda","component":"ProductosComponent"},{"path":"tienda/finalizar-compra","component":"FinalizarCompraComponent","canActivate":["AuthGuard"]},{"path":"tienda/finalizar-compra/orden/:id","component":"OrdenComponent","canActivate":["AuthGuard"]},{"path":"**","redirectTo":""}],"kind":"module"},{"name":"routes","filename":"src/app/auth/auth-routing.module.ts","module":"AuthRoutingModule","children":[{"path":"","component":"MainComponent","children":[{"path":"login","component":"LoginComponent"},{"path":"registro","component":"RegisterComponent"},{"path":"recuperacion","component":"RecoverComponent"},{"path":"**","redirectTo":"login"}]}],"kind":"module"}]}
