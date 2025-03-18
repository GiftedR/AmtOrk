import { AmtgardEvent } from "./amtgardEvent";
import { AmtUser } from "./amtUser";
import { Land } from "./land";

export interface Kingdom
{
	id:number;
	kingdomName:string;
	lands:Land[];
	monarch:AmtUser | undefined;
	regent:AmtUser | undefined;
	champion:AmtUser | undefined;
	primeMinister:AmtUser | undefined;
	gmr:AmtUser | undefined;
	kingdomEvents:AmtgardEvent[];
	readonly kingdomSlug:string;
}

export const emptyKingdom:Kingdom =
{
	id: 0,
	kingdomName: "",
	lands: [],
	monarch: undefined,
	regent: undefined,
	champion: undefined,
	primeMinister: undefined,
	gmr: undefined,
	kingdomEvents: [],
	get kingdomSlug():string {
		return this.kingdomName.toLowerCase().replace(" ","-");
	}
}