namespace MultiFramesProject
{
    class MARCHE_PUBLIC
    {

        private int idMarchePublic;
        private string titre;
        private string description;
        private int idSource;
        private string url;

        public int IdMarchePublic
        {
            get
            {
                return idMarchePublic;
            }

            set
            {
                idMarchePublic = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int IdSource
        {
            get
            {
                return idSource;
            }

            set
            {
                idSource = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public MARCHE_PUBLIC(int pidMarchePublic, string ptitre, string pdescription, int pidSource, string purl)
        {
            this.idMarchePublic = pidMarchePublic;
            this.titre = ptitre;
            this.description = pdescription;
            this.idSource = pidSource;
            this.url = purl;
        }

        public MARCHE_PUBLIC(int pidMarchePublic, string ptitre)
        {
            this.idMarchePublic = pidMarchePublic;
            this.titre = ptitre;
        }
    }
}
