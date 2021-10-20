import { UserPlant } from './index';

export interface User {
    id: number;
    userId: string;
    emailAddress: string;
    password: string;
    userPlants: Array<UserPlant>;
    token: string;
}