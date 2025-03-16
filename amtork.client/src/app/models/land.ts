import { AmtgardEvent } from "./amtgardEvent";
import { AmtUser } from "./amtUser";
import { Kingdom } from "./kingdom";

export interface Land
{
	id:number;
	landName:string;
	landDescription:string;
	landLocation:string;
	kingdomId:number;
	monarch:AmtUser | undefined;
	regent:AmtUser | undefined;
	champion:AmtUser | undefined;
	primeMinister:AmtUser | undefined;
	gmr:AmtUser | undefined;
	landEvents:AmtgardEvent[];
}

export const emptyLand:Land = {
	id: 0,
	landName: "",
	landDescription: "",
	landLocation: "",
	kingdomId: 0,
	monarch: undefined,
	regent: undefined,
	champion: undefined,
	primeMinister: undefined,
	gmr: undefined,
	landEvents: []
}