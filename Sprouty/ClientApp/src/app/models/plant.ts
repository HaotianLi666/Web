import { Url } from "url";


export interface Plant {
	id?: number,
	planturl: string,
	commonName: string,
	scientificName: string,
	info: string
	reminder: boolean;
}