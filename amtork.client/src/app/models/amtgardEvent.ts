export interface AmtgardEvent{
    id:number;
    eventName:string;
    eventLocation:string;
    eventDescription:string;
    eventStartDate:Date;
    eventEndDate:Date;
}

export const emptyEvent:AmtgardEvent = {
    id: 0,
    eventName: "",
    eventLocation: "",
    eventDescription: "",
    eventStartDate: new Date(),
    eventEndDate: new Date()
}