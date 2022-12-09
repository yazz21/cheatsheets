# parent.component.ts
```ts
    @Component({
      selector: 'app-parent',
      template: `
                  <app-first-component 
                      [data]="data" (onData)="updateData($event)"></app-first-component>
                  <app-second-component 
                      [data]="data" (onData)="updateData($event)"></app-second-component>
                `,
      styleUrls: ['./parent.component.css']
    })
    export class ParentComponent {
    
      public data: any;
    
      constructor() {}
    
      updateData(event) {
        this.data = event;
      }
    
    }
```
# first.component.ts
```ts
    @Component({
      selector: 'app-first',
      templateUrl: './first.component.html',
      styleUrls: ['./first.component.css']
    })
    export class FirstComponent implements {

      @Input()
      public data: any

      @Output()
      public onData: EventEmitter<any> = new EventEmitter<any>();

      constructor() { }

      updateData(data) {
        //send data back to parent
        //data could be coming from a service/async http request as well.
        this.onData.emit(data)
      }

    }
```
# second.component.ts
```ts
    @Component({
      selector: 'app-second',
      templateUrl: './second.component.html',
      styleUrls: ['./second.component.css']
    })
    export class SecondComponent implements {

      @Input()
      public data: any

      @Output()
      public onData: EventEmitter<any> = new EventEmitter<any>();

      constructor() { }

      updateData(data) {
        //send data back to parent
        //data could be coming from a service/async http request as well.
        this.onData.emit(data)
      }

    }
```
