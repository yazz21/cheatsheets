
# Grap THe Elemet Tag Using ElementRef
private renderer: Renderer2

// scroll or any other event
this.renderer.listen(this.myElement, 'scroll', (event) => {

    // Do something with 'event'
    console.log(this.myElement.scrollTop);

  });
/////

export class ListenDemo implements AfterViewInit { 
   @ViewChild('testElement') 
   private testElement: ElementRef;
   globalInstance: any;       

   constructor(private renderer: Renderer2) {
   }

   ngAfterViewInit() {
       this.globalInstance = this.renderer.listen(this.testElement.nativeElement, 'click', () => {
           this.renderer.setStyle(this.testElement.nativeElement, 'color', 'green');
       });
    }
}



///
  import { AfterViewInit, Component, ElementRef} from '@angular/core';

constructor(private elementRef:ElementRef) {}

ngAfterViewInit() {
  this.elementRef.nativeElement.querySelector('my-element')
                                .addEventListener('click', this.onClick.bind(this));
}

onClick(event) {
  console.log(event);
}

///
@ViewChild('username') input: ElementRef<HTMLInputElement>;

  ngAfterViewInit() {
    // ElementRef { nativeElement: <input> }
    console.log(this.input);
  }

  ////
  @ViewChild('username') input: ElementRef<HTMLInputElement>;

  constructor(private renderer: Renderer2) {}
  
  ngAfterViewInit() {
    // ElementRef: { nativeElement: <input> }
    console.log(this.input);

    // Access the input object or DOM node
    console.dir(this.input.nativeElement);

    // Manipulate via Renderer2
    this.renderer.setStyle(this.input.nativeElement, 'background', '#d515a0');
  }