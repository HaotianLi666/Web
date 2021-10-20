import internal from 'assert';
import { Plant } from './index';

export interface UserPlant {
	givenName?: string,
	waterSchedule: number, // in days
	lastWatered: Date,
	location: string,
	details: Plant,
}