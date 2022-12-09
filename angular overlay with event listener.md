# template 
```ts
<input
    matInput
    type="text"
    (focus)="isOverlayOpen = true"
    cdkOverlayOrigin
    #demotrigger="cdkOverlayOrigin"
    autocomplete="off"
    (keyup)="keyup($event)"
    [formControl]="stationName"
    name="stationName"
    placeholder="Station_Name"
    />
    
    
    <ng-template
    cdkConnectedOverlayHasBackdrop
    cdkConnectedOverlay
    [cdkConnectedOverlayOrigin]="demotrigger"
    [cdkConnectedOverlayOpen]="isOverlayOpen"
    [cdkConnectedOverlayOffsetY]
    >

    <mat-list class="overlay">
      <mat-list-item
      class="overlay-item"
      *ngFor="let item of datas"
      (click)="stationNammeOverlay(item)"
      >{{item}}
        <hr />
      </mat-list-item>
    </mat-list>
  </ng-template>

  stationNammeOverlay(item) {
    console.log("the data passed: ",item);
    setTimeout(() => {
      this.isOverlayOpen = false
    }, 0);
    //     this.data.getStationName(event.target.value).subscribe((res : any) => {
    //         console.log(res.procHydro_SiteDo);
    //         this.dataSource = new MatTableDataSource<PeriodicElement>(res.procHydro_SiteDo);
    //         console.log('proc_hydro_site', res.procHydro_SiteDo.coordinate);
    //         res.procHydro_SiteDo.filter((val) => val.coordinate != null && val.coordinate.startsWith('POINT')).map((map : any) => {
    //             console.log('map', map.coordinate);
    //             this.markerfunc(map.coordinate)
    // })});
  }