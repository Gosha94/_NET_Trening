namespace InterfaceWithDefaultMethod.Contracts
{
    interface IParser
    {
        public int GetAliasFromId(int aliasId)
        {

            switch (aliasId)
            {
                case 0:
                    return 0;
                    
                case 1:
                    return 1;

                case 2:
                    return 2;

                default:
                    return 0;
            }

        }

    }
}