import { AmtgardEvent } from "./amtgardEvent";
import { Class } from "./class";
import { Kingdom } from "./kingdom";
import { Land } from "./land";


export interface Credit
{
    id:number;
    creditDate:Date;
    creditKingdomId:number;
    creditParkId:number;
    creditEventId:number | undefined;
    creditClassId:number;
    creditCount:number;
}

export const emptyCredit:Credit = {
    id: 0,
    creditDate: new Date(),
    creditKingdomId: 0,
    creditParkId: 0,
    creditEventId: undefined,
    creditClassId: 0,
    creditCount: 0
}