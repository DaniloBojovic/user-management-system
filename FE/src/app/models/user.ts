export interface User {
  id?: number | null;
  firstName?: string;
  lastName?: string;
  username?: string;
  password?: string;
  email?: string;
  status?: string;
  isAdmin?: boolean;
}
