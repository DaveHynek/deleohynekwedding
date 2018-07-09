import { Guest } from './guest';

export class Invitation {
  id: number;
  rsvpCode: string;
  attending: boolean;
  guests: Array<Guest>;
}
