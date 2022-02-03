'use strict';

customElements.define('compodoc-menu', class extends HTMLElement {
    constructor() {
        super();
        this.isNormalMode = this.getAttribute('mode') === 'normal';
    }

    connectedCallback() {
        this.render(this.isNormalMode);
    }

    render(isNormalMode) {
        let tp = lithtml.html(`
        <nav>
            <ul class="list">
                <li class="title">
                    <a href="index.html" data-type="index-link">app-tienda documentation</a>
                </li>

                <li class="divider"></li>
                ${ isNormalMode ? `<div id="book-search-input" role="search"><input type="text" placeholder="Type to search"></div>` : '' }
                <li class="chapter">
                    <a data-type="chapter-link" href="index.html"><span class="icon ion-ios-home"></span>Getting started</a>
                    <ul class="links">
                        <li class="link">
                            <a href="overview.html" data-type="chapter-link">
                                <span class="icon ion-ios-keypad"></span>Overview
                            </a>
                        </li>
                        <li class="link">
                            <a href="index.html" data-type="chapter-link">
                                <span class="icon ion-ios-paper"></span>README
                            </a>
                        </li>
                                <li class="link">
                                    <a href="dependencies.html" data-type="chapter-link">
                                        <span class="icon ion-ios-list"></span>Dependencies
                                    </a>
                                </li>
                    </ul>
                </li>
                    <li class="chapter modules">
                        <a data-type="chapter-link" href="modules.html">
                            <div class="menu-toggler linked" data-toggle="collapse" ${ isNormalMode ?
                                'data-target="#modules-links"' : 'data-target="#xs-modules-links"' }>
                                <span class="icon ion-ios-archive"></span>
                                <span class="link-name">Modules</span>
                                <span class="icon ion-ios-arrow-down"></span>
                            </div>
                        </a>
                        <ul class="links collapse " ${ isNormalMode ? 'id="modules-links"' : 'id="xs-modules-links"' }>
                            <li class="link">
                                <a href="modules/AppModule.html" data-type="entity-link" >AppModule</a>
                                    <li class="chapter inner">
                                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                            'data-target="#components-links-module-AppModule-a96f15b50220120b03e9c46208088d0f505a8dcdd3a92a6b54a7af0a49cae085754294b7f120452672930c11d6f827fecfd2c77d01c5f4a648cba61e62053c82"' : 'data-target="#xs-components-links-module-AppModule-a96f15b50220120b03e9c46208088d0f505a8dcdd3a92a6b54a7af0a49cae085754294b7f120452672930c11d6f827fecfd2c77d01c5f4a648cba61e62053c82"' }>
                                            <span class="icon ion-md-cog"></span>
                                            <span>Components</span>
                                            <span class="icon ion-ios-arrow-down"></span>
                                        </div>
                                        <ul class="links collapse" ${ isNormalMode ? 'id="components-links-module-AppModule-a96f15b50220120b03e9c46208088d0f505a8dcdd3a92a6b54a7af0a49cae085754294b7f120452672930c11d6f827fecfd2c77d01c5f4a648cba61e62053c82"' :
                                            'id="xs-components-links-module-AppModule-a96f15b50220120b03e9c46208088d0f505a8dcdd3a92a6b54a7af0a49cae085754294b7f120452672930c11d6f827fecfd2c77d01c5f4a648cba61e62053c82"' }>
                                            <li class="link">
                                                <a href="components/AppComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >AppComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/CarritoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >CarritoComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/CarroNavbarComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >CarroNavbarComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/CarruselComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >CarruselComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/DetalleProductoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >DetalleProductoComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/FinalizarCompraComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >FinalizarCompraComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/FooterComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >FooterComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/HomeComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >HomeComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/MarketingComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >MarketingComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/NavbarComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >NavbarComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/OrdenComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >OrdenComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ProductosComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ProductosComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/TablaComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >TablaComponent</a>
                                            </li>
                                        </ul>
                                    </li>
                            </li>
                            <li class="link">
                                <a href="modules/AppRoutingModule.html" data-type="entity-link" >AppRoutingModule</a>
                            </li>
                            <li class="link">
                                <a href="modules/AuthModule.html" data-type="entity-link" >AuthModule</a>
                                    <li class="chapter inner">
                                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                            'data-target="#components-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' : 'data-target="#xs-components-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' }>
                                            <span class="icon ion-md-cog"></span>
                                            <span>Components</span>
                                            <span class="icon ion-ios-arrow-down"></span>
                                        </div>
                                        <ul class="links collapse" ${ isNormalMode ? 'id="components-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' :
                                            'id="xs-components-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' }>
                                            <li class="link">
                                                <a href="components/LoginComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >LoginComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/MainComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >MainComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/RecoverComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >RecoverComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/RegisterComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >RegisterComponent</a>
                                            </li>
                                        </ul>
                                    </li>
                                <li class="chapter inner">
                                    <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                        'data-target="#injectables-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' : 'data-target="#xs-injectables-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' }>
                                        <span class="icon ion-md-arrow-round-down"></span>
                                        <span>Injectables</span>
                                        <span class="icon ion-ios-arrow-down"></span>
                                    </div>
                                    <ul class="links collapse" ${ isNormalMode ? 'id="injectables-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' :
                                        'id="xs-injectables-links-module-AuthModule-b0aac0c30ba3fea1e9e4be33d25e1f3e83765537bdfe6b008797b7813985c8378b2df5d46986cd5bc2dd5a3615b99c90fc282d19324215fe48b6e173b843a068"' }>
                                        <li class="link">
                                            <a href="injectables/AuthService.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >AuthService</a>
                                        </li>
                                    </ul>
                                </li>
                            </li>
                            <li class="link">
                                <a href="modules/AuthRoutingModule.html" data-type="entity-link" >AuthRoutingModule</a>
                            </li>
                </ul>
                </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#classes-links"' :
                            'data-target="#xs-classes-links"' }>
                            <span class="icon ion-ios-paper"></span>
                            <span>Classes</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? 'id="classes-links"' : 'id="xs-classes-links"' }>
                            <li class="link">
                                <a href="classes/CarroCompras.html" data-type="entity-link" >CarroCompras</a>
                            </li>
                            <li class="link">
                                <a href="classes/Producto.html" data-type="entity-link" >Producto</a>
                            </li>
                        </ul>
                    </li>
                        <li class="chapter">
                            <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#injectables-links"' :
                                'data-target="#xs-injectables-links"' }>
                                <span class="icon ion-md-arrow-round-down"></span>
                                <span>Injectables</span>
                                <span class="icon ion-ios-arrow-down"></span>
                            </div>
                            <ul class="links collapse " ${ isNormalMode ? 'id="injectables-links"' : 'id="xs-injectables-links"' }>
                                <li class="link">
                                    <a href="injectables/AuthService.html" data-type="entity-link" >AuthService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/CarroDeComprasService.html" data-type="entity-link" >CarroDeComprasService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/EncriptarDesService.html" data-type="entity-link" >EncriptarDesService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/FinalizarCompraService.html" data-type="entity-link" >FinalizarCompraService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/LoginComponent.html" data-type="entity-link" >LoginComponent</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/ProductosService.html" data-type="entity-link" >ProductosService</a>
                                </li>
                            </ul>
                        </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#guards-links"' :
                            'data-target="#xs-guards-links"' }>
                            <span class="icon ion-ios-lock"></span>
                            <span>Guards</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? 'id="guards-links"' : 'id="xs-guards-links"' }>
                            <li class="link">
                                <a href="guards/AuthGuard.html" data-type="entity-link" >AuthGuard</a>
                            </li>
                            <li class="link">
                                <a href="guards/LoginGuard.html" data-type="entity-link" >LoginGuard</a>
                            </li>
                        </ul>
                    </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#interfaces-links"' :
                            'data-target="#xs-interfaces-links"' }>
                            <span class="icon ion-md-information-circle-outline"></span>
                            <span>Interfaces</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? ' id="interfaces-links"' : 'id="xs-interfaces-links"' }>
                            <li class="link">
                                <a href="interfaces/Carrito.html" data-type="entity-link" >Carrito</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/Envio.html" data-type="entity-link" >Envio</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/Pedido.html" data-type="entity-link" >Pedido</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ProductoCarrito.html" data-type="entity-link" >ProductoCarrito</a>
                            </li>
                        </ul>
                    </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#miscellaneous-links"'
                            : 'data-target="#xs-miscellaneous-links"' }>
                            <span class="icon ion-ios-cube"></span>
                            <span>Miscellaneous</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? 'id="miscellaneous-links"' : 'id="xs-miscellaneous-links"' }>
                            <li class="link">
                                <a href="miscellaneous/variables.html" data-type="entity-link">Variables</a>
                            </li>
                        </ul>
                    </li>
                        <li class="chapter">
                            <a data-type="chapter-link" href="routes.html"><span class="icon ion-ios-git-branch"></span>Routes</a>
                        </li>
                    <li class="chapter">
                        <a data-type="chapter-link" href="coverage.html"><span class="icon ion-ios-stats"></span>Documentation coverage</a>
                    </li>
                    <li class="divider"></li>
                    <li class="copyright">
                        Documentation generated using <a href="https://compodoc.app/" target="_blank">
                            <img data-src="images/compodoc-vectorise.png" class="img-responsive" data-type="compodoc-logo">
                        </a>
                    </li>
            </ul>
        </nav>
        `);
        this.innerHTML = tp.strings;
    }
});