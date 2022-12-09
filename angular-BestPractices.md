# nest api call
    ```ts
    this.service.getsmtg().pipe(
        switchMap(data => this.service.getotherthing(data.id))
    ).subscribe(res => console.log(res))
    ```
# any
    bad, use interface, generices, type ..

# cache api using RxJS ShareReplay
```ts
    private readonly cusInfo$:Observable<cusInfo>;

    constructor<T>(url: string): Observable<T> {
        this.cusInfo$ = this.getStaticData<cusInfo>(`${API_ENDPOINT}`)
    }

    getStaticData<T>(url: string): Observable<T>{
        return this.get<T>(url).pipe(shareReplay(1))
    }

    getCusInfoCache(): Observable<cusInfo> {
        return this.cusinfo$
    }
    ```
# Title
```ts 
    import { Title } from "@angular/platform-browser"
    @Component({
        ...
    })
    export class LoginComponent implements OnInit {
        constructor(private title: Title) {}
        ngOnInit() {
            title.setTitle("Login")
        }
    }
    ```
# Meta
```ts
    import { Meta } from "@angular/platform-browser"
    @Component({
        ...
    })
    export class BlogComponent implements OnInit {
        constructor(private meta: Meta) {}
        ngOnInit() {
            meta.updateTag({name: "title", content: ""})
            meta.updateTag({name: "description", content: "Lorem ipsum dolor"})
            meta.updateTag({name: "image", content: "./assets/blog-image.jpg"})
            meta.updateTag({name: "site", content: "My Site"})
        }
    }
```
# Custom INterpoliation
```ts
    @Component({
    template: `
        <div>
            ((data))
        </div>
    `,
    interpolation: ["((","))"]
    })
    export class AppComponent {
        data: any = "dataVar"
    }
```
# Location
We can get the URL of the current browser window using Location service.
With Location, we can go to a URL, navigate forward in the platform’s history, navigate back in the platform’s history, change the browsers URL, replace the top item on the platform’s history stack.

```ts
    import { Location } from "@angular/common"
    @Component({
        ...
    })
    export class AppComponent {
        constructor(private location: Location) {}
        navigateTo(url) {
            this.location.go(url)
        }
        goBack() {
            location.back()
        }
        goForward() {
            location.forward()
        }
    }
```
# Document 
    Let’s say we have an element in our html:

    <canvas id="canvas"></canvas>
    
    We can get hold of the canvas HTMLElement by injecting DOCUMENT:
```ts
    @Component({
    })
    export class CanvasElement {
        constructor(@Inject(DOCUMENT) _doc: Document) {}
    }
    We can then get the HTMLElement of canvas by calling getElementById()

    @Component({
    })
    export class CanvasElement {
        constructor(@Inject(DOCUMENT) _doc: Document) {}
        renderCanvas() {
            this._doc.getElementById("canvas")
        }
    }
```
    We can safely do this using ElementRef and template reference but you got the idea.

    Warning: Tread carefully! Interacting with the DOM directly is dangerous and can introduce XSS risks.

# @Attribute decorator
    enables us to pass static string without a cost at performance by eliminating change detection check on it.
```ts
    @Component({
        ...
    })
    export class BlogComponent {
        constructor(@Attribute("type") private type: string ) {}
    }
```
# HttpInterceptor can be used in:
    Authentication
    Caching
    Fake backend
    URL transformation
    Modifying headers

    It is simple to use, first create a service and implement the HttpInterceptor interface.
```ts
    @Injectable()
    export class MockBackendInterceptor implements HttpInterceptor {
        constructor() {}
        intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
...
        }
    }
    Then, insert it in your main module:

    @NgModule({
        ...
        providers: [
            {
                provide: HTTP_INTERCEPTORS,
                useClass: MockBackendInterceptor,
                multi: true
            }
        ]
        ...
    })
    export class AppModule {}
```
# AppInitializer
    We do sometimes want a piece of code to be run when our Angular app is starting, maybe load some settings, load cache, load configurations or do some check-ins. The AppInitialzer token helps out with that.

    APP_INITIALIZER: A function that will be executed when an application is initialized.

    It is easy to use. Let’s we want this runSettings function to be executed on our Angular app startup:

    function runSettingsOnInit() {
        ...
    }
    We go to our main module, AppModule and add it to providers section in its NgModule decorator:
```ts
    @NgModule({
        providers: [
            { provide: APP_INITIALIZER, useFactory: runSettingsOnInit }
        ]
    })
```
#  Bootstrap Listener
    Just like AppInitializer, Angular has a feature that enables us to listen on when a component is being bootstrapped. It is the APP_BOOTSTRAP_LISTENER.

    All callbacks provided via this token will be called for every component that is  bootstrapped.

    We have many reasons to listen to components bootstrapping, for example, the Router module uses it to destroy and create components based on the route navigation.

    To use APP_BOOTSTRAP_LISTENER, we add it to the providers section in our AppModule  with the callback function:
```ts
    @NgModule({
        {
            provide: APP_BOOTSTRAP_LISTENER, multi: true, 
            useExisting: runOnBootstrap
        }
        ...
    })
    export class AppModule {}
```
# NgPlural
    correctly define grammar in our apps based on the singular/plural value

    To use this directive you must provide a container element that sets the [ngPlural] attribute to a switch expression. Inner elements with a [ngPluralCase] will display based on their expression:
```ts
    <p [ngPlural]="components">
        <ng-template ngPluralCase="=1">1 component removed</ng-template>    
        <ng-template ngPluralCase=">1">{{components}} components removed </ng-template>    
    </p>
```
    See, we have used NgPlural directive to remove the (s) when displaying number of "components removed". It will display:

    // if 1 component
    1 component removed
    // if 5 components
    5 components removed

# trackBy
    Before
```ts
    <li *ngFor="let item of items;">{{ item }}</li>
    
    After

    // in the template
    <li *ngFor="let item of items; trackBy: trackByFn">{{ item }}</li>
    // in the component
    trackByFn(index, item) {    
       return item.id; // unique id corresponding to the item
    }
```

# const vs let
When declaring variables, use const when the value is not going to be reassigned.

Why?

Using let and const where appropriate makes the intention of the declarations clearer. It will also help in identifying issues when a value is reassigned to a constant accidentally by throwing a compile time error. It also helps improve the readability of the code.

# Pipeable operators
    Use pipeable operators when using RxJs operators.

    Why?

    Pipeable operators are tree-shakeable meaning only the code we need to execute will be included when they are imported.

    Before
```ts
    import 'rxjs/add/operator/map';
    import 'rxjs/add/operator/take';
    iAmAnObservable
        .map(value => value.item)
        .take(1);

    After

    import { map, take } from 'rxjs/operators';
    iAmAnObservable
        .pipe(
           map(value => value.item),
           take(1)
         );
```
#  Subscribe in template
    Avoid subscribing to observables from components and instead subscribe to the observables from the template.

    Why?

    async pipes unsubscribe themselves automatically and it makes the code simpler by eliminating the need to manually manage subscriptions.

    This also stops components from being stateful and introducing bugs where the data gets mutated outside of the subscription.

    Before

```ts
    // template
    <p>{{ textToDisplay }}</p>
    // component
    iAmAnObservable
        .pipe(
           map(value => value.item),
           takeUntil(this._destroyed$)
         )
        .subscribe(item => this.textToDisplay = item);
    After

    // template
    <p>{{ textToDisplay$ | async }}</p>
    // component
    this.textToDisplay$ = iAmAnObservable
        .pipe(
           map(value => value.item)
         );
```
# Clean up subscriptions
    unsubscribe from them appropriately by using operators like take, takeUntil, etc ..
    lead to unwanted memory leaks

    Before
```ts
    iAmAnObservable
        .pipe(
           map(value => value.item)     
         )
        .subscribe(item => this.textToDisplay = item);
```
    After

    Using takeUntil when you want to listen to the changes until another observable emits a value:
```ts
    private _destroyed$ = new Subject();
    public ngOnInit (): void {
        iAmAnObservable
        .pipe(
           map(value => value.item)
          // We want to listen to iAmAnObservable until the component is destroyed,
           takeUntil(this._destroyed$)
         )
        .subscribe(item => this.textToDisplay = item);
    }
    public ngOnDestroy (): void {
        this._destroyed$.complete();
        this._destroyed$.next();
    }
```
    Using a private subject like this is a pattern to manage unsubscribing many observables in the component.

    Using take when you want only the first value emitted by the observable:
```ts
    iAmAnObservable
        .pipe(
           map(value => value.item),
           take(1),
           takeUntil(this._destroyed$)
        )
        .subscribe(item => this.textToDisplay = item);
```
    Note the usage of takeUntil with take here. This is to avoid memory leaks caused when the subscription hasn’t received a value before the component got destroyed. Without takeUntil here, the subscription would still hang around until it gets the first value, but since the component has already gotten destroyed, it will never get a value — leading to a memory leak.

# Use appropriate operators
When using flattening operators with your observables, use the appropriate operator for the situation.

switchMap: when you want to ignore the previous emissions when there is a new emission

mergeMap: when you want to concurrently handle all the emissions

concatMap: when you want to handle the emissions one after the other as they are emitted

exhaustMap: when you want to cancel all the new emissions while processing a previous emisssion

