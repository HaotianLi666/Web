import { UserPlant } from './index';

export interface User {
    id: number;
    userId: string;
    emailAddress: string;
    password: string;
    useraPlants: Array<UserPlant>;
    token: string;
}