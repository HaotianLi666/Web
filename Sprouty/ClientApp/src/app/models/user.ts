import { UserPlant } from './index';

export interface User {
    id: number;
    userId: string;
    emailAddress: string;
    userPlants: Array<UserPlant>;
    token: string;
}