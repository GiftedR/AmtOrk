import { Credit } from "./credit";


export interface AmtUser
{
    heraldryPath:string;
    personaName:string;
    isRestricted:boolean;
    isWaivered:boolean;
    isSuspended:boolean;
    isEnabled:boolean;
    passwordExpires:Date;
    reeveQualified:Date;
    corporaQualified:Date;
    parkMemberSince:Date;
    credits:Credit[];
}

export const emptyAmtUser:AmtUser = {
    heraldryPath: "",
    personaName: "",
    isRestricted: false,
    isWaivered: false,
    isSuspended: false,
    isEnabled: false,
    passwordExpires: new Date(),
    reeveQualified: new Date(),
    corporaQualified: new Date(),
    parkMemberSince: new Date(),
    credits: []
}